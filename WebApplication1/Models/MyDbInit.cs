using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MyDbInit
        : System.Data.Entity.CreateDatabaseIfNotExists<MyDb>
    {
        protected override void Seed(MyDb context)
        {
            base.Seed(context);


            context.Xueshengxinxis.Add(new Xueshengxinxi
            {
                Xueshengxuehao = "20180001",
                Xueshengxingming = "张三",
                Xueshengxingbie = "男"

            });
            context.Xueshengxinxis.Add(new Xueshengxinxi
            {
                Xueshengxuehao = "20180002",
                Xueshengxingming = "李四",
                Xueshengxingbie = "女"
            });
            context.Chengjis.Add(new Chengji
            {
                Xuhao="s001",
                Xueshengxuehao = "20180002",
                Xueshengxingming = "李四",
                Xueshengxingbie = "女",
                Kechengmingcheng="体育",
                Kechengchengji=98
            });


        }


    }
}