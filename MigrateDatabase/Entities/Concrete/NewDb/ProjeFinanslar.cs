using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class ProjeFinanslar:IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int ProjeId { get; set; }
		public string KarTahmini { get; set; }
		public string ProjeButcesiUrl { get; set; }
		public decimal? YatirimButcesi1 { get; set; }
		public decimal? YatirimButcesi2 { get; set; }
		public decimal? YatirimButcesi3 { get; set; }
		public decimal? YatirimButcesi4 { get; set; }
		public decimal? YatirimButcesi5 { get; set; }
		public int SatisHedefiAdet1 { get; set; }
		public decimal? SatisHedefiCiro1 { get; set; }
		public decimal? SatisHedefiMaliyet1 { get; set; }
		public int SatisHedefiAdet2 { get; set; }
		public decimal? SatisHedefiCiro2 { get; set; }
		public decimal? SatisHedefiMaliyet2 { get; set; }
		public int SatisHedefiAdet3 { get; set; }
		public decimal? SatisHedefiCiro3 { get; set; }
		public decimal? SatisHedefiMaliyet3 { get; set; }
		public int SatisHedefiAdet4 { get; set; }
		public decimal? SatisHedefiCiro4 { get; set; }
		public decimal? SatisHedefiMaliyet4 { get; set; }
		public int SatisHedefiAdet5 { get; set; }
		public decimal? SatisHedefiCiro5 { get; set; }
		public decimal? SatisHedefiMaliyet5 { get; set; }
		public decimal? NakitAkimGelir1 { get; set; }
		public decimal? NakitAkimGider1 { get; set; }
		public decimal? NakitAkimNakitAkim1 { get; set; }
		public decimal? NakitAkimGelir2 { get; set; }
		public decimal? NakitAkimGider2 { get; set; }
		public decimal? NakitAkimNakitAkim2 { get; set; }
		public decimal? NakitAkimGelir3 { get; set; }
		public decimal? NakitAkimGider3 { get; set; }
		public decimal? NakitAkimNakitAkim3 { get; set; }
		public decimal? NakitAkimGelir4 { get; set; }
		public decimal? NakitAkimGider4 { get; set; }
		public decimal? NakitAkimNakitAkim4 { get; set; }
		public decimal? NakitAkimGelir5 { get; set; }
		public decimal? NakitAkimGider5 { get; set; }
		public decimal? NakitAkimNakitAkim5 { get; set; }
		public string Aciklama { get; set; }
		public DateTime? KayitTarihi { get; set; }
		public bool KayitDurumu { get; set; }

	}
}

