using System;
using System.Threading.Tasks;

namespace WebEditor.Areas {
    public class asyncTaskSample {
        public void go () {
            Console.WriteLine ("go start!");
            var a = p1 ();
            Console.WriteLine ("go end!");
        }

        private async Task<string> p1 () {
            int x = 0;
            Console.WriteLine ("pp start!");
            while (x++ < 6) {
                //System.Threading.Thread.Sleep (1000);
                await MDelay ();
                Console.WriteLine ("x = " + x);
            }
            Console.WriteLine ("pp end!");
            return "return pp!";
        }

        private async Task<string> MDelay () {
            await Task.Run (() => {
                System.Threading.Thread.Sleep (500);
            });
            return "ok";
        }
    }
}