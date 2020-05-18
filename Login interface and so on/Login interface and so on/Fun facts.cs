using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_interface_and_so_on
{
    public partial class Form_Fun_Facts : Form
    {
        public Form_Fun_Facts()
        {
            InitializeComponent();
        }



        private void Random_Fun_fact_Button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(0,52);

            #region //Fun Facts
            if (i==0)
            {
                Fun_Fact_TextBox.Text = "#1 - Humans make 90 percent of our vitamin D naturally from sunlight exposure to our skin – specifically," +
                    " from ultraviolet B exposure to the skin, which naturally initiates the conversion of cholesterol in the skin to vitamin D3.";
            }
            if (i == 1)
            {
                Fun_Fact_TextBox.Text = "#2 - The developer of this app shares the same initials as the HiFi company AKG";
            }
            if(i==2)
            {
                Fun_Fact_TextBox.Text = "#3 - 'My name is Jesper 'plus/minus the loose' Bertelsen' - Jesper Bertelsen";
            }
            if(i==3)
            {
                Fun_Fact_TextBox.Text = "#4 - Only one side of the Moon is visible from Earth because the Moon rotates about its spin axis" +
                    " at the same rate that the Moon orbits the Earth, " +
                    "a situation known as synchronous rotation or tidal locking.";
            }
            if(i==4)
            {
                Fun_Fact_TextBox.Text = "#5 - In lay terms, when standing on the bridge of a ship (or any watercraft)" +
                    " looking toward the bow (front of the ship), " +
                    "starboard refers to the right side of the ship, port refers to the left side." +
                    " At night, the port side of a vessel is indicated with a red navigation light and the starboard side with a green one.";
            }
            if(i==5)
            {
                Fun_Fact_TextBox.Text = "#6 There's a Native American lake named Chargoggagoggmanchauggagoggchaubunagungamaugg." +
                    " It means 'you fish on your side, I fish on my side, and no one fishes in the middle.'" +
                    " Located in the town of Webster, Massachusetts, it is known more commonly as Lake Chaubunagungamaug or Webster Lake.";
            }
            if(i==6)
            {
                Fun_Fact_TextBox.Text = "#7 - Raiders of the Lost Ark (later marketed as Indiana Jones and the Raiders of the Lost Ark)" +
                    " is a 1981 American adventure film directed by Steven Spielberg.";
            }
            if(i==7)
            {
                Fun_Fact_TextBox.Text = "#8 - By 285 CE the Roman Empire had grown so vast that" +
                    " it was no longer feasible to govern all the provinces from the central seat of Rome." +
                    " The Emperor Diocletian divided the empire into halves with the " +
                    "Eastern Empire governed out of Byzantium (later Constantinople) and the Western Empire governed from Rome.";
            }
            if(i==8)
            {
                Fun_Fact_TextBox.Text = "#9 - Jupiter is the most massive planet in our Solar System, meaning it also has the highest gravity." +
                    " If you stood on Jupiter (you would not be able to, because it does not have a solid surface)," +
                    " then you would weigh two and a half times what you would on Earth.";

            }
            if(i==9)
            {
                Fun_Fact_TextBox.Text = "#10 - Although the name of the candy bar sounds like the name of the famous baseball player Babe Ruth," +
                    " the Curtiss Candy Company traditionally claimed that it was named after President Grover Cleveland's daughter, Ruth Cleveland.";
            }
            if(i==10)
            {
                Fun_Fact_TextBox.Text = "#11 - Your ears and your nose never fully stop growing.";
            }
            if(i==11)
            {
                Fun_Fact_TextBox.Text = "#12 - John Lennon signed the paperwork that officially broke up the Beatles" +
                    " at the Polynesian Resort on December 29, 1974." +
                    " John, Julian, and May Pang left New York the following day to spend Christmas in Florida.";
            }
            if(i==12)
            {
                Fun_Fact_TextBox.Text = "#13 - By the time he was five years old, Mozart had complete mastery of keyboards and violin," +
                    " and had written his first five compositions." +
                    " At six, he toured Europe as a child prodigy; by 16, he'd already written three operas and 25 symphonies.";
            }
            if(i==13)
            {
                Fun_Fact_TextBox.Text = "#14 - The half-hour series (The Simpsons) premiered on December 17, 1989, with" +
                    " 'Simpsons Roasting on an Open Fire', a Christmas special." +
                    " 'Some Enchanted Evening' was the first full-length episode produced, but it did not broadcast until May 1990," +
                    " as the last episode of the first season, because of animation problems.";
            }
            if(i==14)
            {
                Fun_Fact_TextBox.Text = "#15 - Elvis recorded over 700 songs. Elvis, through his own publishing companies" +
                    " (Elvis Presley Music, Gladys Music, Whitehaven Music and Elvis Music, Inc.) was part owner (typically half or third) of" +
                    " a great many of the songs he recorded and even some songs he did not record.";
            }
            if(i==15)
            {
                Fun_Fact_TextBox.Text = "#16 - Alexander Graham Bell's telephone patent drawing, March 7, 1876." +
                    " The first successful bi-directional transmission of clear speech by Bell and Watson was made on March 10, 1876 when Bell spoke into the device," +
                    " “Mr. Watson, come here, I want to see you.” and Watson answered.";
            }
            if(i==16)
            {
                Fun_Fact_TextBox.Text = "#17 - NCI was established by Congress in the National Cancer Institute Act of 1937 and is located on the NIH campus at 9000 Rockville Pike, Bethesda, MD 20892," +
                    " with satellite offices in Rockville and Frederick, MD.";
            }
            if (i == 17)
            {
                Fun_Fact_TextBox.Text = "#18 - A solution conducts current when positive and negative ions are randomly dissolved in it." +
                    " Pure water doesn't have enough ions but when you add HCl you add a strong electrolyte so," +
                    " after the addition, solution can conduct electricity very well.";
            }
            if (i == 18)
            {
                Fun_Fact_TextBox.Text = "#19 - The top end of the cashew apple is attached to the stem that comes off the tree." +
                    " The bottom end of the cashew apple attaches to the cashew nut, which is encased in a shell." +
                    " In botanical terms, the cashew apple is an accessory fruit that grows on the cashew seed (which is the nut).";
            }
            if (i == 19)
            {
                Fun_Fact_TextBox.Text = "#20 - The phrase (Time Is Money) was coined by Benjamin Franklin in his Advice to a Young Tradesman (1748): Remember that time is money." +
                    " He that idly loses five shillings' worth of time loses five shillings," +
                    " and might as prudently throw five shillings into the sea.";
            }
            if (i == 20)
            {
                Fun_Fact_TextBox.Text = "#21 - AsapSCIENCE explains blushing as a reaction of the sympathetic nervous system and part of our “fight or flight” response." +
                    " When you're embarrassed, adrenaline is released," +
                    " speeding up your heart rate and dilating your blood vessels to improve your blood flow and oxygen delivery.";
            }
            if (i == 21)
            {
                Fun_Fact_TextBox.Text = "#22 - Within months, two pieces of legislation resulted from Sinclair's novel:" +
                    " The Pure Food and Drug Act and the Meat Inspection Act, both signed into law on June 30th, 1906." +
                    " Sinclair was an instant celebrity and a Socialist hero, and was finally financially stable.";
            }
            if (i == 22)
            {
                Fun_Fact_TextBox.Text = "#23 - The United Kingdom is a country that includes England, Scotland, Wales, and Northern Ireland." +
                    " Its official name is “United Kingdom of Great Britain and Northern Ireland.”" +
                    " England, Wales, Scotland, and Northern Ireland are often mistaken as names of countries," +
                    " but they are only a part of the United Kingdom.";
            }
            if (i == 23)
            {
                Fun_Fact_TextBox.Text = "#24 - Irrationality is cognition, thinking," +
                    " talking or acting without inclusion of rationality. It is more specifically described" +
                    " as an action or opinion given through inadequate use of reason," +
                    " emotional distress, or cognitive deficiency.";
            }
            if (i == 24)
            {
                Fun_Fact_TextBox.Text = "#25 - To find the temperature when both are equal," +
                    " we use an old algebra trick and just set ºF = ºC and solve one of the equations." +
                    " So the temperature when both the Celsius and Fahrenheit scales are the same is -40 degrees.";
            }
            if (i == 25)
            {
                Fun_Fact_TextBox.Text = "#26 - On this day in 1813, the United States gets its nickname, Uncle Sam." +
                    " The name is linked to Samuel Wilson, a meat packer from Troy, New York," +
                    " who supplied barrels of beef to the United States Army during the War of 1812.";
            }
            if (i == 26)
            {
                Fun_Fact_TextBox.Text = "#27 - I made this in school on a thursday c:";
            }
            if (i == 27)
            {
                Fun_Fact_TextBox.Text = "#28 - The earliest writing systems evolved independently and at roughly the same time in Egypt and Mesopotamia," +
                    " but current scholarship suggests that Mesopotamia's writing appeared first." +
                    " That writing system, invented by the Sumerians, emerged in Mesopotamia around 3500 BCE.";
            }
            if (i == 28)
            {
                Fun_Fact_TextBox.Text = "#29 - Forecasters began using names in 1950. In that year and in 1951," +
                    " names were from the international phonetic alphabet in use at the time - Able, Baker, Charlie, etc." +
                    " Female, English-language names were used beginning in 1953. Alternating male and female names were first used to name Atlantic Basin hurricanes in 1979.";
            }
            if (i == 29)
            {
                Fun_Fact_TextBox.Text = "#30 - The atmosphere is primarily composed of nitrogen (78%) and oxygen (21%) with only small concentrations of other trace gases." +
                    " Nearly all atmospheric water vapor or moisture is found in the troposphere," +
                    " so it is the layer where most of Earth's weather takes place.";
            }
            if (i == 30)
            {
                Fun_Fact_TextBox.Text = "#31 - The cobra is deaf to the snake charmer's pipe," +
                    " but follows the visual cue of the moving pipe and it can sense the ground vibrations from the snake charmer's tapping." +
                    " Sometimes, for the sake of safety, all the venom in cobra's teeth is removed.";
            }
            if (i == 31)
            {
                Fun_Fact_TextBox.Text = "#32 - The lamp contains blobs of coloured wax inside a glass vessel filled with clear or translucent liquid;" +
                    " the wax rises and falls as its density changes due to heating from an incandescent light bulb underneath the vessel." +
                    " The appearance of the wax is suggestive of pāhoehoe lava, hence the name.";
            }
            if (i == 32)
            {
                Fun_Fact_TextBox.Text = "#33 - Italian White Truffles are strong in taste, flavour and aroma. These are the rarest of the rare," +
                    " a true gourmet delicacy." +
                    " At the Mushroom Shop we stock white truffles usually mid-december, but they come at a price." +
                    " White truffles retail anywhere between $10,000 - $15,000 per kilo," +
                    " so they are not for the feint-hearted.";
            }
            if (i == 33)
            {
                Fun_Fact_TextBox.Text = "#34 - Australia is the only country that is also a continent." +
                    " Australia lies between the South Pacific Ocean and the Indian Ocean." +
                    " The name Australia comes from the Latin word australis, meaning southern.";
            }
            if (i == 34)
            {
                Fun_Fact_TextBox.Text = "#35 - Google came from the mathematical term googol." +
                    " It's the number one followed by one hundred zeros. In its earliest version," +
                    " Sergey Brin and Larry Page named their search engine 'Back Rub.' They changed the name to Google," +
                    " which stems from the mathematical term 'googol.'";
            }
            if (i == 35)
            {
                Fun_Fact_TextBox.Text = "#36 - Frogs can hear both in the air and below water." +
                    " They do not have external ears;" +
                    " the eardrums (tympanic membranes)" +
                    " are directly exposed or may be covered by a layer of skin" +
                    " and are visible as a circular area just behind the eye.";
            }
            if (i == 36)
            {
                Fun_Fact_TextBox.Text = "#37 - The Hall of Fame quarterback turned head coach" +
                    " made his sarcastic comment after witnessing the highest scoring game in National Football League history." +
                    " That day, his Redskins downed the New York Giants by a score of 72-41 on November 27, 1966.";
            }
            if (i == 37)
            {
                Fun_Fact_TextBox.Text = "#38 - The planet's rotation is slowing down overall because of tidal forces between Earth and the moon." +
                    " Roughly every 100 years," +
                    " the day gets about 1.4 milliseconds, or 1.4 thousandths of a second, longer.";
            }
            if (i == 38)
            {
                Fun_Fact_TextBox.Text = "#39 - Like chop suey, fortune cookies are an American invention." +
                    " They originated in California," +
                    " but who the actual inventor was," +
                    " and which city in California is the true home of the fortune cookie," +
                    " has continued to be a matter of debate." +
                    " Unequivocally not Chinese, the fortune cookie may in fact not even be Chinese American.";
            }
            if (i == 39)
            {
                Fun_Fact_TextBox.Text = "#40 - The 1950s. People. Adlai Stevenson (1900-1965)" +
                    " ran against Eisenhower for president as the Democratic candidate in both 1952 and 1956.";
            }
            if (i == 40)
            {
                Fun_Fact_TextBox.Text = "#41 - Pork, just like any other meat, is not naturally salty." +
                    " Bacon's salt content comes from the curing process," +
                    " where salt is added to the bacon to help preserve it." +
                    " Salt is introduced to bacon in one of two ways: curing and brining.";
            }
            if (i == 41)
            {
                Fun_Fact_TextBox.Text = "#42 - The country's smallest state has the longest official name:" +
                    " State of Rhode Island and Providence Plantations.";
            }
            if (i == 42)
            {
                Fun_Fact_TextBox.Text = "#43 - The statue is of a robed female figure representing Libertas," +
                    " the Roman goddess of freedom," +
                    " who bears a torch and a tabula ansata (a tablet evoking the law)" +
                    " upon which is inscribed the date of the American Declaration of Independence, July 4, 1776.";
            }
            if (i == 43)
            {
                Fun_Fact_TextBox.Text = "#44 - Thespis (/ˈθɛspɪs/; Greek: Θέσπις; fl. 6th century BC) of Icaria (present-day Dionysos, Greece)," +
                    " according to certain Ancient Greek sources and especially Aristotle," +
                    " was the first person ever to appear on stage as an actor playing a character in a play (instead of speaking as him or herself).";
            }
            if (i == 44)
            {
                Fun_Fact_TextBox.Text = "#45 - The head of the femur articulates with the acetabulum in the pelvic bone forming the hip joint," +
                    " while the distal part of the femur articulates with the tibia and patella forming the knee joint." +
                    " By most measures the femur is the strongest bone in the body. The femur is also the longest bone in the body.";
            }
            if (i == 45)
            {
                Fun_Fact_TextBox.Text = "#44 - In early autumn of 1621, the 53 surviving Pilgrims celebrated their successful harvest," +
                    " as was the English custom. During this time," +
                    " 'many of the Indians coming... amongst the rest their great king Massasoit, with some ninety men.'" +
                    " That 1621 celebration is remembered as the 'First Thanksgiving in Plymouth.'";
            }
            if (i == 46)
            {
                Fun_Fact_TextBox.Text = "#45 - The Mercedes-Benz logo is one of those meaningful ones." +
                    " In 1926, Emil Jellinek, Gottlieb Daimler," +
                    " and Carl Benz founded what would become one of the world's foremost luxury car companies." +
                    " The logo is a three-pronged star meant to symbolize universal motorization." +
                    " The three prongs stand for land, water and air.";
            }
            if (i == 47)
            {
                Fun_Fact_TextBox.Text = "#46 - The Olympic flag that will be raised at the Opening Ceremony" +
                    " and will fly over the main stadium during the Games dates back to the 1980s." +
                    " The original five-ringed flag first flew at the Antwerp Games in 1920 and" +
                    " was passed to the mayor of the next host city at the end of the games.";
            }
            if (i == 48)
            {
                Fun_Fact_TextBox.Text = "#47 - No country in the Southern Hemisphere has ever hosted a Winter Games." +
                    " Three continents – Africa, South America, and Antarctica – have never hosted an Olympics." +
                    " A record 202 countries participated in the 2004 Olympic Summer Games in Athens.";
            }
            if (i == 49)
            {
                Fun_Fact_TextBox.Text = "#48 - Cashew nuts are actually the kidney-shaped seeds that adhere to the bottom of the cashew apple," +
                    " the fruit of the cashew tree, which is native to the coastal areas of northeastern Brazil.";
            }
            if(i==50)
            {
                Fun_Fact_TextBox.Text = "#49 - the light we see doesn't originate on the Moon" +
                    " -- the Moon (like the planets) shines by reflected sunlight." +
                    " [Note in passing: the Moon's surface is actually quite black." +
                    " Only about 3% of the Sun's light which hits the Moon is reflected. But that's enough to light up our night sky.]";
            }
            if(i==51)
            {
                Fun_Fact_TextBox.Text = "#50 - It is equal to just under 10 trillion kilometres (or about 6 trillion miles)." +
                    " As defined by the International Astronomical Union (IAU)," +
                    " a light-year is the distance that light travels in vacuum in one Julian year.";
            }
            #endregion
        }

        private void Fun_Fact_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main_Menu MM = new Form_Main_Menu();
            MM.Show();
        }

        private void Fun_Fact_TextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
