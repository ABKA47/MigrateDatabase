using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{

    public class UyelikTipler:IEntity
	{
		public int Id { get; set; }
		public string UyelikTipi { get; set; }
	}

}


