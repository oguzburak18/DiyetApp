using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetApp.Besinler
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<CerezBaklagilGram> CerezBaklagilGramlar { get; set; }
        public List<CerezBaklagilPorsiyon> CerezBaklagilPorsiyonlar { get; set; }
        public List<DigerGram> DigerGramlar { get; set; }
        public List<DigerPorsiyon> DigerPorsiyonlar { get; set; }
        public List<EtGram> EtGramlar { get; set; }
        public List<EtPorsiyon> EtPorsiyonlar { get; set; }
        public List<FastFoodGram> FastFoodGramlar { get; set; }
        public List<FastFoodPorsiyon> FastFoodPorsiyonlar { get; set; }
        public List<IcecekMl> IcecekMler { get; set; }
        public List<IcecekPorsiyon> IcecekPorsiyonlar { get; set; }
        public List<MeyveGram> MeyveGramlar { get; set; }
        public List<MeyvePorsiyon> MeyvePorsiyonlar { get; set; }
        public List<SebzeGram> SebzeGramlar { get; set; }
        public List<SebzePorsiyon> SebzePorsiyonlar { get; set; }
        public List<SutGram> SutGramlar { get; set; }
        public List<SutPorsiyon> SutPorsiyons { get; set; }
        public List<TahilGram> TahilGramlar { get; set; }
        public List<TahilPorsiyon> TahilPorsiyonlar { get; set; }
        public List<YagGram> YagGramlar { get; set; }
        public List<YagPorsiyon> YagPorsiyonlar { get; set; }
        public List<YemekGram> YemekGramlar { get; set; }
        public List<YemekPorsiyon> YemekPorsiyonlar { get; set; }
    }
}
