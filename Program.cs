using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TaskAsync
{
    public class Program
    {
        /// <summary>
        /// 主程式
        /// </summary>
        /// <returns></returns>
        public static async Task Main()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            await WakeUpAsync();

            IList<Task> tasks = new List<Task>();
            tasks.Add(PlayGameAsync());
            tasks.Add(ListenMusicAsync());
            tasks.Add(EatSnackAsync());

            await Task.WhenAll(tasks);

            await GoToBedSleepAsync();

            sw.Stop();
            string second = (sw.Elapsed.TotalMilliseconds / 1000).ToString();
            Console.WriteLine("一共花費:" + second + "秒");
        }

        /// <summary>
        /// 模擬打遊戲
        /// </summary>
        /// <returns></returns>
        private static async Task PlayGameAsync()
        {
            Console.WriteLine("打遊戲");
            await Task.Delay(5000);
        }

        /// <summary>
        /// 模擬聽音樂
        /// </summary>
        /// <returns></returns>
        private static async Task ListenMusicAsync()
        {
            Console.WriteLine("聽音樂");
            await Task.Delay(4000);
        }

        /// <summary>
        /// 模擬吃零食
        /// </summary>
        /// <returns></returns>
        private static async Task EatSnackAsync()
        {
            Console.WriteLine("吃零食");
            await Task.Delay(4000);
        }

        /// <summary>
        /// 模擬起床
        /// </summary>
        /// <returns></returns>
        private static async Task WakeUpAsync()
        {
            Console.WriteLine("起床");
            await Task.Delay(2000);
        }

        /// <summary>
        /// 模擬睡覺
        /// </summary>
        /// <returns></returns>
        private static async Task GoToBedSleepAsync()
        {
            Console.WriteLine("睡覺");
            await Task.Delay(3000);
        }
    }
}
