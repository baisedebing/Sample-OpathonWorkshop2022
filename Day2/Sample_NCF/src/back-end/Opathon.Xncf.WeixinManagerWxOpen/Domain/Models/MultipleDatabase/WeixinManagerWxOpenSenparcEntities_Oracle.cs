﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Senparc.Ncf.Database;
using Senparc.Ncf.Core.Models;
using Senparc.Ncf.XncfBase.Database;
using System;
using System.IO;
using Opathon.Xncf.WeixinManagerWxOpen.Models.DatabaseModel;

namespace Opathon.Xncf.WeixinManagerWxOpen.Models
{
    [MultipleMigrationDbContext(MultipleDatabaseType.Oracle, typeof(Register))]
    public class WeixinManagerWxOpenSenparcEntities_Oracle : WeixinManagerWxOpenSenparcEntities
    {
        public WeixinManagerWxOpenSenparcEntities_Oracle(DbContextOptions<WeixinManagerWxOpenSenparcEntities_Oracle> dbContextOptions) : base(dbContextOptions)
        {
        }
    }
    

    /// <summary>
    /// 设计时 DbContext 创建（仅在开发时创建 Code-First 的数据库 Migration 使用，在生产环境不会执行）
    /// <para>1、切换至 Debug 模式</para>
    /// <para>2、运行：PM> add-migration [更新名称] -c WeixinManagerWxOpenSenparcEntities_Oracle -o Domain/Migrations/Migrations.Oracle </para>
    /// </summary>
    public class SenparcDbContextFactory_Oracle : SenparcDesignTimeDbContextFactoryBase<WeixinManagerWxOpenSenparcEntities_Oracle, Register>
    {
        protected override Action<IServiceCollection> ServicesAction => services =>
        {
            //指定其他数据库
            services.AddDatabase("Senparc.Ncf.Database.Oracle", "Senparc.Ncf.Database.Oracle", "OracleDatabaseConfiguration");
        };

        public SenparcDbContextFactory_Oracle() : base(SenparcDbContextFactoryConfig.RootDictionaryPath)
        {

        }
    }
}
