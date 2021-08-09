using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Threading;

namespace Majo.Controllers
{
    static class ImgToAscii
    {
        
        public static void DrawMajo()
        {
            string title = @"
 /'\_/`\             __           
/\      \     __    /\_\    ___   
\ \ \__\ \  /'__`\  \/\ \  / __`\ 
 \ \ \_/\ \/\ \L\.\_ \ \ \/\ \L\ \
  \ \_\\ \_\ \__/.\_\_\ \ \ \____/
   \/_/ \/_/\/__/\/_/\ \_\ \/___/ 
                    \ \____/      
                     \/___/       
 __  __          ___                            
/\ \/\ \        /\_ \                           
\ \ \_\ \     __\//\ \    _____      __   _ __  
 \ \  _  \  /'__`\\ \ \  /\ '__`\  /'__`\/\`'__\
  \ \ \ \ \/\  __/ \_\ \_\ \ \L\ \/\  __/\ \ \/ 
   \ \_\ \_\ \____\/\____\\ \ ,__/\ \____\\ \_\ 
    \/_/\/_/\/____/\/____/ \ \ \/  \/____/ \/_/ 
                            \ \_\               
                             \/_/               ";

            Console.WriteLine(title);
        }
    }
}
