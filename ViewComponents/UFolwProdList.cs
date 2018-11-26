using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEditor.BusinessLayer;
using WebEditor.DataAccessLayer;
using WebEditor.Models;

namespace WebEditor.ViewComponents {
    public class UFolwProdList : ViewComponent {
        private readonly MulitDbDal dal;

        public UFolwProdList (MulitDbDal pamMulitDbDal) {
            dal = pamMulitDbDal;
        }

        public async Task<IViewComponentResult> InvokeAsync (UserInfoBL pamUserInfoBL, int pamUserId) {
            //UserRelationship user_relationship = await pamUserInfoBL.GetUserRelationship (pamUserId);
            //URelationship user_relationship = ViewBag.URelationship;
            //UserInfoBL ubl = new UserInfoBL (dal, HttpContext);
            List<Product> product_list = await pamUserInfoBL.GetFocusProducts (pamUserId);
            //乱序list
            Random random = new Random ();
            int count = product_list.Count;
            for (int i = 0; i < product_list.Count; i++) {
                Product tmpProd = product_list[i];
                product_list.RemoveAt (i);
                product_list.Insert (random.Next (count), tmpProd);
            }

            return View ("Index", product_list);
        }
    }
}