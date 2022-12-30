﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_image_character : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 100));
        }
    }
}
