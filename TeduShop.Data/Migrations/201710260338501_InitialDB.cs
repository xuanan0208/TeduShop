namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pages", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Pages", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Pages", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "MetaKeyword", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.PostCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "MetaKeyword", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Posts", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "MetaKeyword", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Status");
            DropColumn("dbo.Posts", "MetaDescription");
            DropColumn("dbo.Posts", "MetaKeyword");
            DropColumn("dbo.Posts", "UpdatedBy");
            DropColumn("dbo.Posts", "UpdatedDate");
            DropColumn("dbo.Posts", "CreatedBy");
            DropColumn("dbo.Posts", "CreatedDate");
            DropColumn("dbo.PostCategories", "Status");
            DropColumn("dbo.PostCategories", "MetaDescription");
            DropColumn("dbo.PostCategories", "MetaKeyword");
            DropColumn("dbo.PostCategories", "UpdatedBy");
            DropColumn("dbo.PostCategories", "UpdatedDate");
            DropColumn("dbo.PostCategories", "CreatedBy");
            DropColumn("dbo.PostCategories", "CreatedDate");
            DropColumn("dbo.Pages", "Status");
            DropColumn("dbo.Pages", "MetaDescription");
            DropColumn("dbo.Pages", "MetaKeyword");
            DropColumn("dbo.Pages", "UpdatedBy");
            DropColumn("dbo.Pages", "UpdatedDate");
            DropColumn("dbo.Pages", "CreatedBy");
            DropColumn("dbo.Pages", "CreatedDate");
        }
    }
}
