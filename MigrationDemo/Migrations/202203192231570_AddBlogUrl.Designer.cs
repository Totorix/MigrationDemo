﻿// <auto-generated />
namespace MigrationDemo.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.4.4")]
    public sealed partial class AddBlogUrl : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddBlogUrl));
        
        string IMigrationMetadata.Id
        {
            get { return "202203192231570_AddBlogUrl"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}