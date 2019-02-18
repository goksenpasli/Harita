using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
namespace Harita
{
	public  class Veri
	{
        public List<string> iller;

        public Veri() => iller = new List<string>
            {
                "Adana",
                "Adıyaman",
                "Afyonkarahisar",
                "Ağrı",
                "Amasya",
                "Ankara",
                "Antalya",
                "Artvin",
                "Aydın",
                "Balıkesir",
                "Bilecik",
                "Bingöl",
                "Bitlis",
                "Bolu",
                "Burdur",
                "Bursa",
                "Çanakkale",
                "Çankırı",
                "Çorum",
                "Denizli",
                "Diyarbakır",
                "Edirne",
                "Elazığ",
                "Erzincan",
                "Erzurum",
                "Eskişehir",
                "Gaziantep",
                "Giresun",
                "Gümüşhane",
                "Hakkâri",
                "Hatay",
                "Isparta",
                "İçel",
                "İstanbul",
                "İzmir",
                "Kars",
                "Kastamonu",
                "Kayseri",
                "Kırklareli",
                "Kırşehir",
                "Kocaeli",
                "Konya",
                "Kütahya",
                "Malatya",
                "Manisa",
                "Kahramanmaraş",
                "Mardin",
                "Muğla",
                "Muş",
                "Nevşehir",
                "Niğde",
                "Ordu",
                "Rize",
                "Sakarya",
                "Samsun",
                "Siirt",
                "Sinop",
                "Sivas",
                "Tekirdağ",
                "Tokat",
                "Trabzon",
                "Tunceli",
                "Şanlıurfa",
                "Uşak",
                "Van",
                "Yozgat",
                "Zonguldak",
                "Aksaray",
                "Bayburt",
                "Karaman",
                "Kırıkkale",
                "Batman",
                "Şırnak",
                "Bartın",
                "Ardahan",
                "Iğdır",
                "Yalova",
                "Karabük",
                "Kilis",
                "Osmaniye",
                "Düzce"};

        public static string İl
		{
			get;
			set;
		}
		static readonly Random rd = new Random();
        public static void Yeniİl(MainWindow mv) => mv.tbilismi.Text = new Veri().iller[rd.Next(0, new Veri().iller.Count)];
    }
}