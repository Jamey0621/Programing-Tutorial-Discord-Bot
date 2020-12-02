using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Programing_Tutorial.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        //greatings and replys to simple stuff
        [Command("hi")]
        public async Task Hi()
        {
            await ReplyAsync("Why hi there, I am a bot prgramed by Jamey That will help you learn anything you need!");
        }
        [Command("thank you")]
        public async Task ThankYou()
        {
            await ReplyAsync("Im here to help now get to learning!");
        }

        // questions 



        // Tutorial videos for spacific programing lang

        [Command("python")]
        public async Task Python()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=rfscVS0vtbw&t=11s");
        }
        // lets add to python
        [Command("python django")]
        public async Task PythonDjango()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=F5mRW0jo-U4&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=15");
        }
        // cool python projects to do 
        [Command("python project")]
        public async Task PythonProjec()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=XGf2GcyHPhc");
            await ReplyAsync("https://www.youtube.com/watch?v=Flm2YHEFd5A");
            await ReplyAsync("https://www.youtube.com/watch?v=Sz0_2fp27Q0");
        }

        [Command("c#")]
        public async Task CSharp()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=GhQdlIFylQ8&t=4095s");
        }
        //lets add go deeper into c#
        [Command("c# blazor")]
        public async Task CBlazor()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=4G_BzLxa9Nw&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=11");
        }
        [Command("c# asp.net")]
        public async Task AspNet()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=BfEjDD8mWYg&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=39");
        }

        [Command("c# sql")]
        public async Task CSharpSql()
        {
            await ReplyAsync("https://www.youtube.com/playlist?list=PLxefhmF0pcPlIV1NGkJvNeDQY3IeTimSj");
        }
        // cool c# projects to do 
        [Command ("c# projects")]
        public async Task CSharpProjects()
        {
            await ReplyAsync("https://www.youtube.com/playlist?list=PLVJxzz1cOIRFdvJPZbhX4M4TIPteYdztw");
        }
        [Command("java")]
        public async Task Java()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=grEKMHGYyns");
        }

        [Command("c++")]
        public async Task CPlusPlus()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=vLnPwxZdW4Y");
        }
        [Command("c")]
        public async Task C()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=KJgsSFOSQv0&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=29");
        }
        [Command("typescript")]
        public async Task TypeScript()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=BwuLxPH8IDs");
        }
        [Command("cobol")]
        public async Task Colbol()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=TBs7HXI76yU");
        }

        [Command("kotlin")]
        public async Task Kotlin()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=F9UC9DY-vIU");
        }

        [Command("swift")]
        public async Task Swift()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=comQ1-x2a1Q");
        }

        [Command("dart")]
        public async Task Dart()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=Ej_Pcr4uC2Q");
        }

        [Command("javascript")]
        public async Task Javascript()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=PkZNo7MFNFg");
        }

        [Command("php")]
        public async Task Php()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=OK_JCtrrv-c&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=8");
        }

        [Command("r")]
        public async Task R()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=_V8eKsto3Ug&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=33");
        }
        [Command("golang")]
        public async Task Go()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=YS4e4q9oBaU&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=37");
        }

        [Command("flutter")]
        public async Task Flutter()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=x0uinJvhNxI");
        }
        [Command("f#")]
        public async Task F()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=c7eNDJN758U");
        }
        [Command("rust")]
        public async Task Rust()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=zF34dRivLOw");
        }
        [Command("perl")]
        public async Task Perl()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=OVP-CqefrZY&list=PL_RGaFnxSHWpqRBcStwV0NwMA3nXMh5GC");
        }


        //web dev

        [Command("web development")]
        public async Task WebDev()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=Q33KBiDriJY");
        }

        [Command("html")]
        public async Task Html()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=pQN-pnXPaVg");

            await ReplyAsync("https://www.youtube.com/watch?v=mU6anWqZJcc&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=2");
        }

        [Command("css")]
        public async Task Css()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=1Rs2ND1ryYc&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=3");

            await ReplyAsync("https://www.youtube.com/watch?v=ieTHC78giGQ&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=4");
        }

        [Command("react")]
        public async Task React()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=4UZrsTqkcW4&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=17");
        }

        [Command("ui design")]
        public async Task UiDesign()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=_P3CrgFlXhg&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=28");
        }

        [Command("ruby")]
        public async Task Ruby()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=t_ispmWmdjY&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=28");
        }
        [Command("mern")]
        public async Task Mern()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=7CqJlxBYj-M&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=34");
        }
        [Command("angular")]
        public async Task Angular()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=2OHbjep_WjQ&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=39");
        }
        // database 
        [Command("sql")]
        public async Task Sql()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=HXV3zeQKqGY&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=12");
        }

        [Command("sql queries")]
        public async Task SqlQueries()
        {
            await ReplyAsync("https://www.youtube.com/playlist?list=PL6EDEB03D20332309");
        }

        [Command("mysql")]
        public async Task MySql()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=7S_tz1z_5bA");
        }
        [Command("database design")]
        public async Task DataBaseDesign()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=ztHopE5Wnpc&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=21");
        }
        //data structures
        [Command("data structures")]
        public async Task DataStructures()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=RBSGKlAvoiM&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=25");
        }

        [Command("data science")]
        public async Task DataScience()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=XU5pw3QRYjQ&list=RDCMUC8butISFwT-Wl7EV0hUK0BQ&index=29");
        }
        // other
        [Command ("arduino project")]
        public async Task ArduinoProject()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=nL34zDTPkcs");
        }
        [Command("network")]
        public async Task Network()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=qiQR5rTSshw");
        }
        [Command("bash")]
        public async Task Bash()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=e7BufAVwDiMS");
        }

    }
}
