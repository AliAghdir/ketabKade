﻿// <auto-generated />
using KetabKade.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KetabKade.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211004145342_FirstMig")]
    partial class FirstMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KetabKade.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pic")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "عشق آدمو کور می کنه. هردومون سعی کردیم به پسرهامون چیزهایی رو بدیم که خودمون نیاز داشتیم، نه چیزهایی رو که اونا نیاز داشتن. به قدری سرگرم بازنویسی گذشته‌ی خودمون بودیم که زمان حال اونا رو تباه کردیم.",
                            Name = "هری پاتر و فرزند نفرین شده",
                            pic = 1,
                            price = 50000
                        },
                        new
                        {
                            Id = 2,
                            Description = "جیمز وود در این کتاب خاطره و نقد ادبی را به نحوی شگرف به هم آمیخته و به کمک آن ارتبـاط بین داستان و زندگی واقعی را نشان داده است. او استدلال می‌کند که، در میان همه‌ی هنرها، ادبیات داستانی دارای توانایی منحصربه‌فردی برای توصیف شیوه‌ی زندگی ماست، و می‌تواند نهاد زندگی‌ را از مرگ و فراموشی تاریخی نجات دهد. وود عمل خواندن و درک کردن را در اینجا یکی از مقدس‌ترین فعالیت‌های شخصی انسان می‌شمارد و بحث‌های درخشـانی درباره‌ی چند اثر ادبـی مطرح می‌کند. او در این کتـاب رابطه‌ی صمیمی خود با کلمه‌ی مکتوب را آشکار می‌سازد. نزدیک‌ترین چیز به زندگی نه فقط کتابی موجز با استدلال‌های محکم درباره‌ی ادبیات داستانی‌ست، بلکه شرح شخصی وجدآوری است از تعمق درباره‌ی همدستی پرثمر میان خواننده و نویسنده و منتقد. جیمز وود، متولد 1965، در شهر دورام، انگلستان، زاده و بزرگ شده و اکنون مقیم نیویورک  است. منتقد ادبی و جستار‌نویس نشریه‌ی نیویورکر و چند نشریه‌ی دیگر و استاد مهمان در دانشگاه هاروارد است.",
                            Name = "نزدیکترین چیز به زندگی",
                            pic = 2,
                            price = 95000
                        },
                        new
                        {
                            Id = 3,
                            Description = "جیمز وود در این کتاب خاطره و نقد ادبی را به نحوی شگرف به هم آمیخته و به کمک آن ارتبـاط بین داستان و زندگی واقعی را نشان داده است. او استدلال می‌کند که، در میان همه‌ی هنرها، ادبیات داستانی دارای توانایی منحصربه‌فردی برای توصیف شیوه‌ی زندگی ماست، و می‌تواند نهاد زندگی‌ را از مرگ و فراموشی تاریخی نجات دهد. وود عمل خواندن و درک کردن را در اینجا یکی از مقدس‌ترین فعالیت‌های شخصی انسان می‌شمارد و بحث‌های درخشـانی درباره‌ی چند اثر ادبـی مطرح می‌کند. او در این کتـاب رابطه‌ی صمیمی خود با کلمه‌ی مکتوب را آشکار می‌سازد. نزدیک‌ترین چیز به زندگی نه فقط کتابی موجز با استدلال‌های محکم درباره‌ی ادبیات داستانی‌ست، بلکه شرح شخصی وجدآوری است از تعمق درباره‌ی همدستی پرثمر میان خواننده و نویسنده و منتقد. جیمز وود، متولد 1965، در شهر دورام، انگلستان، زاده و بزرگ شده و اکنون مقیم نیویورک  است. منتقد ادبی و جستار‌نویس نشریه‌ی نیویورکر و چند نشریه‌ی دیگر و استاد مهمان در دانشگاه هاروارد است.",
                            Name = "بلندیهای بادگیر",
                            pic = 3,
                            price = 60000
                        },
                        new
                        {
                            Id = 4,
                            Description = "راساس یک نظرسنجی از خوانندگان ادبیات، رمان بلندی های بادگیر در میان 20 اثر کلاسیک عاشقانه بر صدر نشست. براساس رمان کلاسیک بلندی های بادگیر اثر امیلی برونته تاکنون نمایش های موزیکال، تئاتر، اپرا و فیلم های بسیاری ساخته شده است و کارگردانان آمریکایی، انگلیسی، اسپانیایی، فرانسوی و ژاپنی هر یک برداشت خود را از این اثر به شیوه ای خاص بیان کرده اند.",
                            Name = "سه گانه ی خواب گردها",
                            pic = 4,
                            price = 45000
                        },
                        new
                        {
                            Id = 5,
                            Description = "شروع نوشته های من در مطبوعات به سال های 49-50 می رسد که اولین کتاب‌ام :زندگی جنگ و دیگر هیچ» از اوریانا فلاناچی در انتشارات امیرکبیر منتشر شد. کتاب «حال حیرت» هم، باز همان نوشته ها و گفت و گو هایم در جراید است. تکه های از برخی گفتگوها را هم به دلیل طولانی بودن گزینش شده اند.",
                            Name = "حال حیرت",
                            pic = 5,
                            price = 30000
                        },
                        new
                        {
                            Id = 6,
                            Description = "ورشید زمستانی پشت دیوارهای قصر پایین رفت و سیلاس سرعتش را زیادتر کرد. باید از دروازه می‌گذشت؛ قبل از این‌که شب می‌شد و پل متحرک دروازه‌ی شمالی را بالا می‌کشیدند و قفل می‌کردند. سیلاس در این لحظه‌ی به خصوص چیزی را کنارش حس کرد؛ چیزی زنده، تقریبا زنده. حس می‌کرد قلب انسان کوچکی در نزدیکی‌اش می‌تپد. او جادوگری معمولی بود و فقط می‌توانست چیزها را حس کند. و چون جادوگر معمولی خوبی هم نبود، باید روی آن‌ها تمرکز می‌کرد. برف هم‌چنان می‌بارید که آرام ایستاد. جای پاهایش تقریبا حالا پر شده بودند. صدایی شنید: یک فین‌فین، ناله و شاید صدای نفس کشیدنی کوتاه؟",
                            Name = "افصون",
                            pic = 6,
                            price = 77000
                        },
                        new
                        {
                            Id = 7,
                            Description = "شهرسازی ایران تاریخ . شناخت شهرهای ایران باستان در دوران هخامنشیان اشکانیان و ساسانیان",
                            Name = "ایران شهر",
                            pic = 7,
                            price = 32000
                        },
                        new
                        {
                            Id = 8,
                            Description = "داستان خط، شرح سرگذشتی است که بیش از بیست هزار سال را درمی‌نوردد و با تمامی جنبه‌های زندگی بشری تماس می‌یابد. این کتاب پس از پرداختن به مسئله‌ی منشأ و تکامل خط و تحول نقش و مفهوم آن در سده‌ی گذشته، و بحث درباره‌ی رابطه‌ی متقابل جامعه و خط، به تاریخچه‌ی خطوط گوناگون پرداخته و ویژگی‌ها و تحولات هر یک از آن‌ها را دنبال می‌کند. گزارش ماجراهای رمزیابی و خواندن خطوط ناشناخته، و تصویرهای گویایی از متن‌های بازمانده از هر خط، کتاب را زنده‌تر و رساتر می‌سازد. جنبه‌های گوناگون خط، از جمله جنبه‌ی زیباشناختی آن، رابطه‌ی آن با سیاست و دین و تحول اقتصادی و فنی نیز بررسی شده و نشان داده می‎‌شود در عصر جدید تکنولوژی اطلاعات، آینده‎‌ی خط به عنوان عامل ذخیره‎‌سازی اطلاعات چه می‌تواند باشد.",
                            Name = "تاریخ خط",
                            pic = 8,
                            price = 43000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
