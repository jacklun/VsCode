using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using WebEditor.DataAccessLayer;
using WebEditor.Models;

namespace WebEditor.BusinessLayer {
    public class UserInfoBL {
        private readonly MulitDbDal dal;

        public UserInfoBL (MulitDbDal parmMulitDbDal) {
            dal = parmMulitDbDal;
        }

        public async Task<bool> LoginOrCreate (UserBase parmUserBase) {
            if (parmUserBase.uname == null || parmUserBase.password == null) {
                return false;
            }

            var user_detial = dal.UserBases.FirstOrDefaultAsync (u => u.uname == parmUserBase.uname && u.password == parmUserBase.password);
            if (user_detial != null) {
                //写入session
                CookieManager.SetSession ("IsLogin", "1");
                //写入永久cookie
                CookieManager.SetCookies ("uname", user_detial.Result.uname);
                CookieManager.SetCookies ("password", user_detial.Result.password);
                return true;
            } else {
                if (ValidationUserDetial (parmUserBase)) {
                    dal.Add (parmUserBase);
                    await dal.SaveChangesAsync ();
                    return true;
                } else {
                    return false;
                }
            }
        }

        public UserBase TransUserBase (string parmOpenId = null, string parmUName = null, string parmPassword = null) {
            UserBase user_base;
            if (string.IsNullOrEmpty (parmOpenId)) {
                //其他浏览器，有用户名密码
                if (string.IsNullOrEmpty (parmUName) || string.IsNullOrEmpty (parmPassword)) return null;
                user_base = new UserBase ();
                user_base.uname = parmUName;
                user_base.password = parmPassword;
                return user_base;
            } else {
                user_base = new UserBase ();
                user_base.openid = parmOpenId;
                return user_base;
            }
        }

        public async Task<UserBase> GetUserBase (string parmOpenId = null, string parmUName = null, string parmPassword = null) {
            Console.WriteLine ("GetUserDetial..........");
            UserBase user_base = TransUserBase (parmOpenId, parmUName, parmPassword);
            //根据cookie检测数据库
            if (user_base.openid != null) {
                //以下是原始sql执行，缺点是紧耦合
                //var ui = dal.UserBases.FromSql ("SELECT id FROM UserDetials", new MySqlParameter ("@OpenId ", parmOpenId)).FirstOrDefaultAsync ().Result;
                var ui = await dal.UserBases.FirstOrDefaultAsync (u => u.openid == user_base.openid);
                //var ui = await dal.UserDetials.Include (u => u.mycompany).FirstOrDefaultAsync (u => u.openid == user_detial.openid);
                user_base = ui;
            } else {
                /*
                //以下是原始sql执行，缺点是紧耦合
                MySqlParameter[] paras = new MySqlParameter[] {
                    new MySqlParameter ("@uname", parmUName),
                    new MySqlParameter ("@password", parmPassword)
                };
                var ui = dal.UserDetials.FromSql ("SELECT * FROM UserDetials where uname=@uname and password=@password", paras).FirstOrDefaultAsync ().Result;
                */
                var ui = await dal.UserBases.FirstOrDefaultAsync (u => u.uname == parmUName && u.password == parmPassword);
                //var ui = await dal.UserDetials.Include (u => u.mycompany).FirstOrDefaultAsync (u => u.uname == user_detial.uname && u.password == user_detial.password);
                user_base = ui;
            }
            if (user_base != null) {
                //写入session
                return user_base;
            } else {
                return null;
            }
        }

        //检测用户名等是否合法
        public bool ValidationUserDetial (UserBase parmUserBase) {
            return true;
        }
    }
}