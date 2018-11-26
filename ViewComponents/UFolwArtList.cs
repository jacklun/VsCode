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
    public class UFolwArtList : ViewComponent {
        private readonly MulitDbDal dal;

        public UFolwArtList (MulitDbDal pamMulitDbDal) {
            dal = pamMulitDbDal;
        }

        public async Task<IViewComponentResult> InvokeAsync (UserInfoBL pamUserInfoBL, int pamUserId) {
            var art_categorys = await pamUserInfoBL.GetFocusArtCategorys (pamUserId);
            //乱序list
            Random random = new Random ();
            int count = art_categorys.Count;
            for (int i = 0; i < art_categorys.Count; i++) {
                ArtCategory tmpArtCategory = art_categorys[i];
                art_categorys.RemoveAt (i);
                art_categorys.Insert (random.Next (count), tmpArtCategory);
            }

            //填充第一个tab内容列表
            var articles = await pamUserInfoBL.GetArticles (art_categorys[0].id);
            art_categorys[0].articles = articles;

            return View ("Index", art_categorys);
        }
    }
}