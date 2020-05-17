using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using WindowsFormsApp1;


namespace WindowsFormsApp2
{
  
    static class Program
    {
       
        static void Main(string[] args)
        {

            //string tipinde bi list oluştur.
            List<Burçlar> Burçlist = new List<Burçlar>();

            //burç adlarını for döngüsüyle ekle.
            string[] Burçadı = new string[12]
            { "Koç", "Boğa", "İkizler", "Yengeç", "Aslan", "Başak", "Terazi", "Akrep", "Yay", "Oğlak", "Kova", "Balık" };

            //Burçların kadın olumsuz özelliklerini for döngüsüyle ekle.
            string[] Burçkadınolumlu = new string[12]
            {
                "Koç burcu kadınının olumlu özellikleri arasında; dürüst olması en dikkat çekici özelliğidir." +
                "Yalan söylemekten pek hoşlanmaz, zorunda kalmadıkça. " +
                "Kendilerine olan güveni üst düzeydedir. Atılgan ve girişimcidir. " +
                "Her zaman en önde olmak ister. Enerjileri daima üst seviyededir. ",
                "Boğa burcu kadınının olumlu özellikleri arasında; güvenilir olması en dikkat çekici özelliğidir. " +
                "Tutardır ve fevri hareketleri yoktur. Sadık, sabırlı ve duyarlıdır." +
                "Her zaman kibar olmasını bilir, katı yürekli değildir. En önemlisi de oldukça dengeli kişiliği vardır." +
                "Kararlıdır, istediğini elde eder, ulaşmak istediğine mutlaka ulaşır. ",
                "İkizler burcu kadınının olumlu özellikleri arasında; en dikkat çekici özelliği zeki olmasıdır. " +
                "Her zaman uyumlu olmasını bilir. Bilgi seviyesi oldukça yüksektir. " +
                "Esprilidir ve eğlenceli bir kadındır. " +
                "İletişim yeteneğinin üst düzey olması olumlu özelliklerinden öne çıkanıdır. " +
                "Entelektüel, anlama yetisi yüksek, mantıklı ve sosyal bir kişiliğe sahiptir. ",
                "Yengeç burcu kadınının olumlu özellikleri arasında; en dikkat çekici olanı yumuşak ve duygusal olmasıdır. " +
                "Anaç bir kadındır. Koruma ve destek duygusu en üst düzeydedir. " +
                "Sabretmesini iyi bilir ve oldukça sevimli bir kişiliğe sahiptir. En güvenilir kadınlar arasındadır. " +
                "Ailesine çok fazla düşkündür. Yuva düşkünü ve tutumlu bir kadındır.",
                "Aslan burcu kadınının olumlu özellikleri arasında; heyecanlı olması en dikkat çekici özelliğidir. Girişimci bir ruha sahiptir. " +
                "Her anlamda yaratıcılık gösterir. Sadık, tutkulu ve iyimserdir. Eğlenceli bir kadındır. " +
                "Son derece gururlu ve sorumluluk sahibidir. Geniş düşünce yapısına sahiptir. ",
                "Başak burcu kadınının olumlu özellikleri arasında; en dikkat çekici olanı ise titiz olmasıdır. " +
                "Yardıma her zaman hazırdır, ellerinden geleni yapmak isterler. Kibar ve alçakgönüllüdür. " +
                "Pratik olmasını iyi bilir, son derece güvenilir ve sevecen bir karaktere sahiptir. Duyarlı, dikkatli ve dürüsttür. ",
                "Terazi burcu kadınının olumlu özellikleri arasında; en dikkat çekici olanları entelektüel olması ve uyumlu olmasıdır. " +
                "Her duruma ve her olaya uyum sağlamasını iyi bilir. Sosyal, realist, nazik ve sevgi doludur. " +
                "Zarif bir kişiliğe ve görünüme sahiptir. Adaletli ve hırslıdır. ",
                "Akrep burcu kadınının olumlu özellikleri arasında; en dikkat çekeni ise sadık olmasıdır. Kimseyi yarı yolda bırakmaz ve ihanet etmez. " +
                "Duygusal davranışlar sergiler ve sabırlıdır.Sorumluluklarının farkındadır ve tutumludur davranışlara sahiptir. " +
                "Yaratıcı olması bir diğer olumlu özelliği olarak dikkat çeker. Tutkulu, çekici ve sağlam karaktere sahiptir. ",
                "Yay burcu kadınının olumlu özellikleri arasında; aşırı coşkulu olması ve geniş bakış açısına sahip olması dikkat çeker." +
                "Açık sözlüdür ve gizlilikten hoşlanmaz. " +
                "Dürüst bir karaktere sahiptir. İdealist bir kadındır ve oldukça sevimlidir. " +
                "İyimser, düşünceli ve uyumludur. Özgürlüğünü sever ve güvenilir bir kadındır. ",
                "Olumlu özellikleri arasında en dikkat çeken güvenilir olmasıdır. Aldığı kararların arkadasın da durur, özenlidir ve sabırlı davranır. " +
                "Her şeyin düzenli olmasını ister. Aşırılıktan hoşlanmaz. ",
                "Kova burcu kadınının olumlu özellikleri arasında; insancıl olması en dikkat çekici özelliğidir. Hemen her konuda yaratıcı olmayı bilir. " +
                "Arkadaşlıklara önem verir. " +
                "İhtiyacı olan her insana yardım etmeyi sever. İyimser ve hoşgörülü kadındır. ",
                "Balık burcu kadınının olumlu özellikleri arasında; en dikkat çekici olanı ise duyarlı olmasıdır. Hemen her alanda yaratıcı olmasını bilir." +
                "Her insana karşı şefkatli olmayı iyi bilirler." +
                "Romantik kadındır ve zarif kişiliğe sahiptir. Son derece kibar ve sempatiktir. Son derece güvenilir kadındır ve tutkuludur. "
            };

            //burçların kadın olumsuz özelliklerini ekle.
            string[] Burçkadınolumsuz = new string[12]
            {
                "Koç Burcu Kadınının olumsuz özellikleri arasında; en dikkat çekici olanı aşırı tepkisel olmasıdır. " +
                "Sabretmeyi bilmez, aceleci davranır. Kolayca kızıp, sinirlenebilir. Dik kafalıdır ve bildiğini okur. " +
                "Kimi zaman kavgacı olabilir ve insanlarla alay edebilir. İnatçı ve kimi zaman bencil davranışlar sergileyebilir.",
                "Boğa burcu kadınının olumsuz özellikleri arasında; sabit fikirli olması herkes tarafından ilk fark edilen özelliğidir. " +
                "Düşünceleri ve kararları kolay kolay değişmez. İnatçı ve rahatına düşkündür. " +
                "Kimi zaman kendisini düşünür. Aşırı kıskanç ve takıntılıdır. Zaman zaman açgözlülük sergileyebilir. Keyfine aşırı düşkündür.",
                "İkizler burcu kadınının olumsuz özellikleri arasında; yüzeysel olması ve duygusuz olması en dikkat çekici olanıdır. " +
                "Kimi zaman sinirli davranışlar sergileyebilir.Karar vermekte zorluk çeker. Huzursuz ve dedikodu yapmaya eğilimlidir. " +
                "Aşırı meraklı olması da kimi zaman olumsuz bir özellik olarak gösterilebilir.",
                "Yengeç burcu kadınının olumsuz özellikleri arasında; bağımlı olması en dikkat çeken özelliğidir. Her işe burnunu mutlaka sokar. " +
                "Aşırı duygusal olması kimi zaman olumsuzluk olarak önlerine çıkabilir. Kimi zaman kolayca sinirlenebilir. " +
                "Zaman zaman da somurtkan olması olumsuz özellikleri arasındadır. Kendine acımaya karşı eğilimleri vardır ve ketumdur.",
                "Aslan burcu kadınının olumsuz özellikleri arasında; en dikkat çekici olanı ise bencil olmasıdır. " +
                "Kimi zaman sadece kendisini düşünür ve buna göre davranır." +
                "Küstah, diktatör ruhlu ve kaba olabilir.Keyfine aşırı derecede düşkündür. " +
                "Eli açık olması ve aşırı savurgan olması diğer olumsuz özellikleri arasında yerini alır. Düşüncelerini değiştirmek oldukça zordur.",
                "Başak burcu kadınının olumsuz özellikleri arasında; gergin ve fazla mantıklı hareket etmesi en dikkat çekici olanıdır. H" +
                "er zaman endişeli davranır, dalgın ve sinsidir." +
                "Aşırı derecede tutucu, takıntılı ve zorluk çıkaran yapısı vardır. Geleneklerini aşırı derecede bağlıdır ve genellikle yenilikten hoşlanmaz.",
                "Terazi burcu kadınının olumsuz özellikleri arasında; kararsız olması herkes tarafından fark edilen özelliğidir. Sevdikleri zaman kıskanç olabilir." +
                "Bağımlılık düşkündür ve tembel bir kişiliğe sahiptir. Zevkine aşırı düşkün olması kimi zaman olumsuzluk olarak gösterilebilir. Eleştiri yanı fazladır.",
                "Akrep burcu kadınının olumsuz özellikleri arasında; en dikkat çekici olanı yıkıcı bir karaktere sahip olmasıdır. " +
                "Aşırı derecede kıskanç olabilir ve sinsi davranışlar sergileyebilir." +
                "Uyum sağlamada zorluk çeker, geniş bakış açısına sahip değildir ve inatçıdır. Her zaman, herkesten kuşku duyar. " +
                "Kindar olması diğer olumsuz özelliği olarak göze çarpar.",
                "Yay burcu kadınının olumsuz özellikleri arasında; başına buyruk olması, kendini aşırı derecede beğenmiş olması ve abartılı olması vardır. " +
                "Genel olarak huzursuzluk içerisindedir ve kaprisli bir kadındır. " +
                "Kimi zaman patavatsız olabilir ve sorumluluklarını unutabilirler. Dikkatsiz olması, göze çarpan olumsuz özelliğidir.",
                "Olumsuz özellikleri arasında en dikkat çeken kesin kararlı olmaları, iyimser olmamaları ve pinti olmalarıdır. " +
                "Aldıkları bir kararı kolay kolay değiştirmezler. Bakışlarından dolayı çoğu insan katı yürekli olduklarını düşünebilir.",
                "Kova burcu kadınının olumsuz özellikleri arasında; saplantılı olması en dikkat çekici olumuz özelliğidir. " +
                "Kimi zaman anlaşılmaz, dar görüşlü ve huysuz bir kadın olabilir. Geleneklere bağlı değildir ve karşı çıkar. " +
                "Sorumluluklarının farkında değildir ve zaman zaman dengesiz davranışlar sergileyebilir.",
                "Balık burcu kadınının olumsuz özellikleri arasında; kararsız ve hayalci olması en dikkat çekici olanıdır. Kendine acıyan bir kişiliğe sahiptir." +
                "Kötümser ve aşırı derecede tutumlu olması olumsuz özelliği olarak öne çıkar. " +
                "İnatçı ve cimri bir kişiliğe sahiptir. Dışarıdan bakıldığında katı görüşlü olması diğer olumsuz özelliği olarak dikkat çeker."
            };

            // Burçların erkek olumlu özelliklerini ekle.
            string[] Burçerkekolumlu = new string[12]
            {
                "Koç burcu erkeğinin olumlu özellikleri arasında; belki de en önemli özelliği yönetici ruhlu olmasıdır. " +
                "Cesurdur, atılgan bir yapıya sahiptir ve bu nedenle hiçbir şeyden çekinmez." +
                "Oldukça hırslı bir yapıya sahiptir ve enerjileri daima üst düzeydedir. Kararlıdır, aldıkları kararlardan kolay kolay dönmezler. " +
                "Son derece coşkulu, girişken ve tutkulu bir erkektir. Tüm bunlar Koç burcu erkeğinin olumlu özellikleri olarak dikkat çeker. ",
                "Boğa burcu erkeğinin olumlu özellikleri arasında; güvenilir ve dayanıklı olması en dikkat çekici olanıdır. Sabretmeyi bilir, aceleci davranmaz. " +
                "Dengeli ve mantıklı bir kişiliğe sahiptir. Sert ve kaba davranışları yoktur. " +
                "Son derece güvenilir, uyumlu, duyarlı ve sıcakkanlıdır. Sadık bir karaktere sahip olması Boğa burcu erkeğinin bir diğer olumlu özelliği olarak göze çarpar.",
                "İkizler burcu erkeğinin olumlu özellikleri arasında; çok yönlü olması en dikkat çekici özelliğidir. Kolaylıkla değişime ayak uydurabilirler. " +
                "Uyumlu, her işin altından kalkabilen, eğlenceli, kolayca anlayan ve konuşkan bir erkektir. " +
                "Enerjisi daima yüksektir, entelektüel, mantıklı ve arkadaş canlısı bir karaktere sahiptir. İkizler burcu erkeğinin diğer göze çarpan olumlu özelliği ise çekici ve bağımsız olmasıdır. ",
                "Yengeç burcu erkeğinin olumlu özellikleri arasında; en dikkat çekici özelliği iyi kalpli olmasıdır. Son derece duyarlı ve sevimli bir erkektir. " +
                "Amaçları doğrultusunda hareket eden, pratik zekalı ve beceriklidir. " +
                "Koruma içgüdüsü en üst seviyededir. Duygusal, destekçi ve tutumludur. Ailesine düşkün olması diğer olumlu özelliğidir. ",
                "Aslan burcu erkeğinin olumlu özellikleri arasında; yüce gönüllü olması en dikkat çekici özelliğidir. Yardımsever, yaratıcı ve coşkulu bir karaktere sahiptir." +
                "Geniş düşünce yapısına sahiptir. Gururlu, sadık, kararlı ve iyimserdir. " +
                "Kendinden emin oluşu diğer göze çarpan olumlu özelliği olarak dikkat çeker. Sorumluluklarının farkındadır ve eğlenceli bir karaktere sahiptir. ",
                "Başak burcu erkeğinin olumlu özellikleri arasında; en dikkat çeken özelliği titiz olması ve yardımsever olmasıdır. " +
                "Her zaman kibar davranışlar sergiler, etkili bir karaktere sahiptir ve güvenilirdir. " +
                "Mantıklı hareket eder ve sevecen bir kişiliğe sahiptir. Her olayı inceler ve son derece dürüsttür. Son derece düzenli ve dakiktir.",
                "Terazi burcu erkeğinin olumlu özellikleri arasında; en önemli olanı uyumlu olması ve adaletli olmasıdır. Dengeli bir erkektir. " +
                "Büyüleyici bir kişiliğe sahiptir, duygusal, karizmatik ve hırslıdır. " +
                "Terazi burcu erkeğinin göze çarpan diğer olumlu özellikleri ise sanatçı ruhlu, idealist, entelektüel, nazik ve sevgi dolu olmasıdır. ",
                "Akrep burcu erkeğinin olumlu özellikleri arasında; sadık ve gerçekçi olması en dikkat çekici özelliğidir. " +
                "Yaratıcı olmasını bilir, tutkulu, karizmatik ve enerjili bir erkektir. Kararlıdır ve kolay kolay değiştirmez. " +
                "Sorumluluklarının farkındadır ve onlardan kaçmaz. Tutkulu, amansız ve anlayışlı oluşu diğer olumlu özellikleri arasında dikkat çekicidir. ",
                "Yay burcu erkeğinin olumlu özellikleri arasında; coşkulu ve güvenilir olması en dikkat çekici olumlu özelliğidir. Son derece sevimli, idealist ve cömert bir kişiliğe sahiptir. " +
                "Özgürlüğe aşık, yargılama yeteneğine sahip ve uyumlu olması diğer göze çarpan olumlu özellikleridir. Açık sözlü, araştırmacı ve güler yüzlüdür. ",
                "Güvenilir olmaları, planlı hareket etmeleri ve disiplinden hiçbir zaman kopmamaları olumlu özellikleri arasındadır. Hırslı olmaları en büyük artıları diyebiliriz. ",
                "Kova burcu erkeğinin olumlu özellikleri arasında; en dikkat çekici olanı insancıl ve arkadaşlığa önem veriyor olması dikkat çeker. " +
                "İnsanlara yardım etmekten hoşlanır, oldukça yardımsever bir karaktere sahiptir. İyimser, yaratıcı ve bağımsızdır. ",
                "Balık burcu erkeğinin olumlu özellikleri arasında; şairane ruhlu olması ve son derece duyarlı olması en dikkat çekici olumlu özelliğidir. Her zaman, herkese karşı şefkatli davranırlar. " +
                "Romantik bir erkektir. Son derece güvenilirdir. Düzenli, sabırlı ve kararlıdır. Tutkulu ve sempatik olması diğer olumlu özellikleri olarak dikkat çeker. "
            };

            //Burçların erkek olumsuz özelliklerini ekle.
            string[] Burçerkekolumsuz = new string[12]
            {
                "Koç burcu erkeğinin olumsuz özellikleri arasında; en dikkat çekici olanı aşırı derecede inatçı bir yapıya sahip olmasıdır. Her zaman, her şeyi merak eder ve öğrenmek ister. " +
                "Sadece kendini düşünen bir yapıya sahip olması bir diğer olumsuz özelliği olarak göze çarpar. Zaman zaman tembellik yapabilir ve açgözlü olabilir. " +
                "Kolayca sinirlenir ve sabırsızdır. İnsanlarla alay etmesi ve kimi zaman ciddi olmaması olumsuz özellikleri arasında bulunur. ",
                "Boğa burcu erkeğinin olumsuz özellikleri arasında; en dikkat çekici olanı kıskanç var inatçı olmasıdır. " +
                "Tembel ve can sıkıcı olabilir. Aşırı takıntılı, kendini düşünen ve keyif düşkünü bir yapıya sahiptir." +
                "Dar görüşlüdür ve görüşü kolay kolay değişmez. Maddeci, katı ve uyuşuk olması diğer olumsuz özellikleri arasındadır",
                "İkizler burcu erkeğinin olumuz özellikleri arasında; sorumsuz, kararsız ve iyi yüzlü olması dikkat çekici olanıdır. Huzursuz bir yapıya sahiptir." +
                "Aşırı meraklı olması dikkat çeken olumsuz özelliğidir. Kolay sinirlenir ve bunu kontrol edemez. Kurnaz, şımarık ve gevezedir. ",
                "Yengeç burcu erkeğinin olumsuz özellikleri arasında; sürekli değişim göstermesi, fazla heyecanlı olması en dikkat çeken olumsuz özelliğidir. " +
                "Bağımlı, ketum ve kendine acımaya eğilimli bir karaktere sahiptir. " +
                "Aşırı duygusal olması olumsuz özelliği olarak gösterilebilir. Denetleyici, bağışlamaz ve somurtkandır.",
                "Aslan burcu erkeğinin olumsuz özellikleri arasında; en dikkat çekici olanı ise benmerkezci olmasıdır. Eli açıktır ve savurganlık yapabilir. " +
                "Kendini aşırı derecede beğenmiştir. Zaman zaman küstahlık yapabilir. " +
                "Burnu havada, keyfine aşırı derecede düşkün ve sabit düşüncelidir. Aslan burcu erkeğinin bir diğer olumsuz özelliği ise iktidar delisi olmasıdır. ",
                " Başak burcu erkeğinin olumsuz özellikleri arasında; fazla detaycı olması en göze batan özelliğidir. Her zaman endişelidir ve sivri dillidir. " +
                "Karamsar görüşe sahiptir. Fazla mantıklı olması olumsuz özellik olarak göze çarpar. " +
                "Kimi zaman aşırı sinirli olabilir ve gergin olabilir. Önemsiz konular üzerinde yoğun zaman harcaması olumsuz özelliklerinden bir tanesidir.",
                "Terazi burcu erkeğinin olumsuz özellikleri arasında; en dikkat çekici olanı kararsız olmasıdır. Zaman zaman aşırı kıskanç olabilir. " +
                "Tembel, her işe karışan, eleştirici ve yüzeyseldir. Kolay etki altında kalıyor olması bir diğer olumsuz özelliği olarak dikkat çeker. ",
                "Terazi burcu erkeğinin olumsuz özellikleri arasında; en dikkat çekici olanı kararsız olmasıdır. Zaman zaman aşırı kıskanç olabilir. " +
                "Tembel, her işe karışan, eleştirici ve yüzeyseldir. Kolay etki altında kalıyor olması bir diğer olumsuz özelliği olarak dikkat çeker. ",
                "Yay burcu erkeğinin olumsuz özellikleri arasında; en dikkat çekici, göze çarpanı huzursuz ve fevri olmasıdır. Duyarsız davranışlar sergileyebilir. " +
                "Kendini aşırı derecede beğenmiştir. Uyuşuk, yani pratik olmayan bir düşünce yapısına sahiptir. Tembel, patavatsız, fazla iyimser ve dikkatsizdir. ",
                "Biraz sert olmaları, geleneksel davranmaları ve iyimserlikten uzak yapıları olumsuz özellikleri arasındadır. İnatçıdır ve dediği olsun ister. ",
                "Kova burcu erkeğinin olumsuz özellikleri arasında; sorumsuz olması ve anlaşılmaz davranışlar sergilemesi dikkat çeken olumsuz özellikleridir. " +
                "Saplantılı bir erkektir ve kimi zaman dengesiz davranışlarda bulunabilir. Huysuz, aşırı yenilikçi ve dik kafalı olması diğer olumsuz özellikleri olarak gösterilebilir. ",
                "Balık burcu erkeğinin olumsuz özellikleri arasında; karar vermekte zorlanıyor olması en göze batan olumsuz özelliğidir. " +
                "Tembel, hastalık hastası ve kendine acıyan bir yapıda olması diğer olumsuz özellikleri olarak dikkat çeker. " +
                "Katı görünümlü olması, kesin tavırlı olması, dik başlı ve cimri olması Balık burcu erkeğinin olumsuz özellikleri arasındadır. "
            };

            //Burçların aralıklarını belirt.
            string[] Burçbaşlangıç = new string[12]
            {
            "21/03",
            "21/04",
            "22/05",
            "23/06",
            "23/07",
            "23/08",
            "23/09",
            "23/10",
            "22/11",
            "22/12",
            "22/01",
            "20/02"
            };

            string[] Burçbitiş = new string[12]
            {
            "20/04",
            "21/05",
            "22/06",
            "22/07",
            "22/08",
            "22/09",
            "22/10",
            "21/11",
            "21/12",
            "21/01",
            "19/02",
            "20/03"
            };
            // nesneye atama
            for (int i = 0; i < 12; i++)
            {
                Burçlar burçlar = new Burçlar();
                burçlar.adı = Burçadı[i];

                burçlar.erkekOlumlu = Burçerkekolumlu[i];
                burçlar.erkekOlumsuz = Burçerkekolumsuz[i];

                burçlar.kadinOlumlu = Burçkadınolumlu[i];
                burçlar.kadinOlumsuz = Burçkadınolumsuz[i];

                burçlar.tarihBaslangic = Burçbaşlangıç[i];
                burçlar.tarihBitis = Burçbitiş[i];

                Burçlist.Add(burçlar);
            }

            //Deneme  
            DateTime date = DateTime.ParseExact("22/01", "dd/MM", null);

            Console.WriteLine("Çıktı " + date);

            for(int i = 0; i < 12; i++)
            {
                DateTime baslangic = Convert.ToDateTime(Burçlist[i].tarihBaslangic);
                DateTime bitis = Convert.ToDateTime(Burçlist[i].tarihBitis);

                if(baslangic.Month <= date.Month && date.Month <= bitis.Month)
                {
                    if(baslangic.Day <= date.Day || date.Day <= bitis.Day)
                    {
                        Console.WriteLine("Burc: " + Burçlist[i].adı);
                    }
                }


            }




            




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            




        }
    }
}
