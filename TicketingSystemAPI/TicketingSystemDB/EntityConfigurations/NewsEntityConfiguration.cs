using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketingSystemDB.Entities.Games;
using TicketingSystemDB.Entities.News;
using TicketingSystemDB.Entities.Players;

namespace TicketingSystemDB.EntityConfigurations
{
    public class NewsEntityConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.Property(e => e.UrlId).HasMaxLength(150);
            builder.Property(e => e.MainTitle).HasMaxLength(100);
            builder.Property(e => e.SubTitle).HasMaxLength(150);
            builder.Property(e => e.DetailsTitle).HasMaxLength(1000);
            builder.Property(e => e.Content).HasMaxLength(10000);
            builder.Property(e => e.PublishDate).HasMaxLength(20);
            builder.Property(e => e.Image).HasMaxLength(20);
            SetData(builder);
        }

        private static void SetData(EntityTypeBuilder<News> builder)
        {
            builder.HasData(
                    new News {
                        Id = 1,
                        UrlId = "we-won-our-second-hungarian-cup-2023-04-09",
                        MainTitle = "We won our second Hungarian Cup!",
                        SubTitle = "Strength demonstration in the final against Sopron KC! Our boys won 92-48!",
                        DetailsTitle = "A Falco korán tetemes előnyt szerzett, és 92–48-ra legyőzte a Sopront a férfi kosárlabda Magyar Kupa vasárnap esti budapesti döntőjében. A szombathelyi csapat rendkívül domináns játékkal, demoralizáló fölénnyel szerezte meg a klub történetének második Magyar Kupa-elsőségét.",
                        Content = "A fináléra képletesen szólva „felbillent” a Tüskecsarnok, hiszen a döntő résztvevőinek szurkolói a létesítmény egyik felében, egymással szemben kaptak elhelyezést, a másik oldalon a bronzmeccsben érintett Szolnok és Kecskemét szimpatizánsainak zöme nem maradt az aranycsatára.\r\n\r\nSoproni oldalon megsokszorozódtak a drukkerek, érthető, a KC kilenc éve járt legutóbb ilyen közel az aranyhoz, akkor Pécsen szoros meccsen (70–68) kikapott az idei bronzérmes Szolnoktól. A Falco két éve hat sikertelen döntő után megszerezte a klub első MK-győzelmét Budapesten, a Ludovika Arénában, ám tavaly óriási meglepetésre már a negyeddöntőben kiesett, miután kikapott a végül ezüstérmes Szegedtől.\r\n\r\nA találkozó esélyese egyértelműen a szombathelyi együttes volt, amely a bajnokság alapszakaszában oda-vissza megverte a Sopront, s amely kevésbé küzdelmes és fárasztó meccset követően jutott a vasárnapi döntőbe. A bemelegítés alatti hangpárbajt egyértelműen a kék-fehér drukkerek nyerték meg, de amikor feldobták a labdát, a sárga-fekete B-közép is kiengedte a hangját.\r\n\r\ndegesen kezdtek a játékosok, kivéve Kovács Benedeket, a Falco fiatal magyar bedobóját, aki két egymást követő hibátlan hárompontossal nyitott, majd Perl Zoltán duplájával már 14–5-re vezettek a szombathelyiek, így Kosztasz Flevarakisznak, a Sopron görög edzőjének alig öt perc után időt kellett kérnie. Hiába, két perc múlva már 14 ponttal állt jobban a vasi gárda, s 28–15-re hozta az első tíz percet. Önbizalom nélkül és pontatlanul játszott az SKC, s elvétve tudta csak kivédekezni a szombathelyiek támadásait, akik kívül-belül domináltak, és a félidőre 18 pontos vezetésre tettek szert.\r\n\r\nHa nem kupadöntőről lett volna szó, akkor az eredmény és a látottak alapján már lefutottnak is tekinthettük volna a meccset, annyira egyértelmű volt a hárompontosokat 54, a ketteseket 55 százalékkal értékesítő Falco fölénye.\r\n\r\nA fordulás után sem jött a fordulat, a sárga-feketék kézben tartották a mérkőzést – s ugyan becsülettel küzdött a Sopron, nem volt benne a játékában, hogy akár csak megszorítsa a vasiakat, akik a 26. percben már 25 pontos előnyben voltak, a vége pedig totális kiütés lett. 92–48",
                        PublishDate = new DateTime(2023, 04, 09, 18, 25, 0),
                        Image = "kupagyozelem"
                    },
                    new News
                    {
                        Id = 2,
                        UrlId = "curiousities-about-our-next-opponent-deac-2023-04-10",
                        MainTitle = "Curiousities about our next opponent: DEAC!",
                        SubTitle = "Before our next match, we have some interesing informations.",
                        DetailsTitle = "Itt vannak az érdekességek.",
                        Content = "A holnapi találkozó előtt összegyűjtöttünk néhány érdekességet.\r\n\r\nA @deackosar az alapszakaszt a nyolcadik helyen zárta, 14-12-es mérleggel.\r\n\r\n🆚Az alapszakasz egymás elleni mérkőzéseit 1-1-re zártuk, miután idegenben 69-71 arányban győzni tudtunk, majd hazai pályán 75-81 arányban vereséget szenvedtünk a debreceniektől.\r\n\r\n❌Negyedöntős ellenfelünk az alapszakasz mérkőzései alapján átlagban 79.1 pontot engedett ellenfeleinek, ez az ötödik legkevesebb a ligában.\r\n\r\n🔝Kulcsjátékosuk Michaelyn Scott, a DEAC előző, Kaposvár elleni mérkőzésén 22 játékperc alatt 19 dobott pontot, 2 lepattanót és 7 asszisztot jegyzett.\r\n\r\nHajrá Falco!",
                        PublishDate = new DateTime(2023, 04, 10, 12, 22, 0),
                        Image = "deac_cur"
                    },
                    new News
                    {
                        Id = 3,
                        UrlId = "confident-win-against-deac-2023-04-12",
                        MainTitle = "Confident win at the playoff start: Falco - DEAC 87-67!",
                        SubTitle = "Stefan Pot scored 20 points, we had the lead throughout the match!",
                        DetailsTitle = "Végig vezetve sikerült diadalmaskodnunk a szurkoloink örömére.",
                        Content = "A negyeddöntős párharc első mérkőzésének elején nehezen lendültünk ritmusba, a vendégek pedig kinti dobásokkal érvényesültek. Persze így is megnyertük az első, majd az azt követő három játékrészt is. A hajrában csak a különbség volt kérdéses, Stefan Pot 20 ponttal volt a legeredményesebb játékosunk ezzel 1-0-ra vezetünk.\r\n\r\nAz 1. negyedet jobban kezdtük, a játékrész derekán 13-8-ra vezettünk. Aztán a debreceni tripla után Cowels adott mesteri asszisztot Kellernek, 15-11. Perl kiváló védekezése után a befejezés is remek volt, 19-13. Az első pillanattól kiváló hangulatot teremtettek szurkolóink, akik a 8. percben a vendégek 3 pontot érő távoli dobását, majd Barac vonalról szerzett pontját és a második hibás büntető után egy Tiby-kosarat láthattak, 22-16. Ezután Neuwirth dobott újabb debreceni triplát, az utolsó másodpercben pedig a kupadöntő MVP-je, Tiby dobott ,,egylábas” duplát, 24-19.\r\n\r\nA 2. negyed Drenovac hármasával startolt, majd Perl 2+1 pontja, aztán már a negyedik DEAC-tripla érkezett meg, 27-24. Drenovac a vonalról is hiba nélkül dobott, Scott pedig egy közelivel megszerezte a vezetést a vendégeknek, 27-28. Barac kosara után vettük vissza a minimális előnyt, ezt Keller a vonalról növelte, 31-28. Scott duplája után, a 14. percben Cowels dobta be első hármasunkat, Polyák is kintről reagált, 34-33. A játékrész derekán Scott a vonalról egalizált, majd a minimális vezetést is visszavette, 34-35. Pot a vonalról egyenlített, de csak egyet dobott be, az ellentámadás után pedig Neuwirth ugyanennyit, 35-36. Ezt követően Zozó mesteri akció végén szerzett 2 pontot, majd egy újabb támadásunk végén már távolról is betalált, 40-36. Mielőtt elléptünk volna, Mandic a 16. perc végén időt kért. Hiába, újabb labdaszerzésünk és támadásunk után, Zozó a vonalról is betalált, 42-36. A félidő hajrájában tovább gyakorolhatta a büntetők értékesítését Zozó, akinek nem is volt ezzel gondja, 46-37. Rengeteg szabálytalanságot fújtak be ezekben a percekben a játékvezetők, ezt kihasználva előbb Polyák szépített, majd Pot állította vissza a 9 pontos előnyt, 48-39. Keller újabb kosara után először vezettünk tíznél több egységgel, Mandic újra magához hívta fiait, 50-39. A félidő utolsó percében, Tóth Ádám vonalról szerzett pontjai után Konakov mester is megállíttatta az órát, 50-41. Jól tette, bejött a megbeszélt figura, Pot triplájának örülhettünk, 53-41.\r\n\r\nA 3. negyed elején elején még jobban elléptünk, előbb Tiby akadálytalanul szerezhetett 2 pontot, majd Cowels és Pot is betalált közelről, 59-41. Mandic alig 1 perc után újra időt kért. Ezután Tóth Á., majd Pot is közelről talált be, 61-43. Drenovac vette el a labdát irányító játékosunktól, Pottól, majd könnyű kosarat szerzett, ezt Govens-tripla követte, 61-48-nál már Konakov mester kért időt. Jókor, Keller és Pot révén 65-48-ra módosult az eredmény. A negyed közepén agresszív védekezésre váltottak a debreceniek, Zozót így sem tudták megállítani, és mivel Govensre reklamálás miatt technikait fújtak, Barac ezt kihasználta és már 21 ponttal mentünk. Drenovac pontjaival jöttek közelebb, de Barac gyorsan reagált, aztán Zozó sem tudott hibázni a vonalról, 73-54. Az utolsó percben, Brown, illetve Scott hármasa is célba ért, 76-57.\r\n\r\nA 4. negyedet Krivacevic közelijével kezdtük, majd Taylor zsákolt, 78-61. Pot palánkos duplája után Krivi a vonalról gyarapította a pontjait, 81-61. A játékrész derekán Scott kozmetikázott a hátrányon, 81-65. A 37. percben Brown ugrott egy hatalmasat a labdáért, majd fájdalmasan kapott a térdéhez. Több perces ápolás után a 7 pontos Brown sajnos nem folytathatta, bízunk benne, hogy nincs nagy baj. Ezt követően Kenéz szerezte meg első pontjait, Cowels reagált azonnal, 87-67. A dudaszó előtt 2 perccel mindkét csapat mestere a fiatalokat hozta pályára. Ezek nem a mi perceink voltak, de a vendégek sem jöttek közelebb, rendkívül pontszegény utolsó játékrészt követően 87-67 maradt az eredmény.\r\n\r\nFalco-Vulcano Energia KC Szombathely – DEAC 87-67 (24-19, 29-22, 23-17, 11-10)\r\nRájátszás, 1. forduló, 1. mérkőzés.\r\nSzombathely, Arena Savaria\r\nJátékvezetők: Praksch Péter Árpád, Söjtöry Tamás Ferenc, Kovács Nimród János (Téczely Tamás)\r\n\r\nFalco: Pot 20/6, Kovács 2, Brown 7/3, Tiby 10, Keller 9. Csere: Perl 19/3, Barac 10, Cowels 7/3, Krivacevic 3, Sövegjártó -, Takács Zs. -, Horváth -.\r\n\r\nDebrecen: Govens 6/6, Mócsán 4, Gáspár 2, Drenovac 18/6, Tóth Á. 7. Csere: Garamvölgyi -, Scott 13/3, Taylor 5, Polyák 6/3, Neuwirth. 4/3, Kenéz 2.\r\n\r\nSzép volt, fiúk, folytatás szombaton, de már Debrecenben!",
                        PublishDate = new DateTime(2023, 04, 12, 20, 11, 0),
                        Image = "falco_deac"
                    },
                    new News
                    {
                        Id = 4,
                        UrlId = "zach-brown-injury-2023-04-13",
                        MainTitle = "Fortunately Zach Brown's injury isn't that serious!",
                        SubTitle = "Our beloved small-forward hopefully can play in the finals!",
                        DetailsTitle = "Ugyanakkor közel sem biztos, hogy Milos Konakov vezetőedző beveti a játékost.",
                        Content = "Zach brown injury content...",
                        PublishDate = new DateTime(2023, 04, 13, 09, 01, 0),
                        Image = "injury-report"
                    },
                    new News
                    {
                        Id = 5,
                        UrlId = "falco-zte-tomorrow-2023-05-08",
                        MainTitle = "Falco - ZTE tomorrow!",
                        SubTitle = "We can advance to the finals.",
                        DetailsTitle = "Minden jegy elkelt.",
                        Content = "Third match, current standing: Falco 2 - 0 ZTE",
                        PublishDate = new DateTime(2023, 05, 08, 10, 06, 0),
                        Image = "falco-zte"
                    }
                );
        }
    }
}
