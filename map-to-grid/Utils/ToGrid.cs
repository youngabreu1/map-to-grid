using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace map_to_grid.Utils
{
    public class ToGrid
    {

        public List<string> time { get; set; }
        public List<string> dur { get; set; }
        public List<TimeSpan> gridTime { get; set; }
        public string[] dataList { get; set; }

        public ToGrid()
        {


        }

        public void GetData(string path)
        {
            List <DateTime> toDateTime = new List<DateTime>();
            List<DateTime> toDateTimeStr = new List<DateTime>();
            List<string> doc = new List<string>();
            gridTime = new List<TimeSpan>();
            time = new List<string>();
            dur = new List<string>();

            dataList = File.ReadAllLines($"{path}");
            dataList.ToList();

            foreach (string item in dataList)
            {
                time.Add(item.Split(' ')[0]);
                dur.Add("00:" + item.Split(' ', '=', ',')[2]);
            }

            for (int i = 0; i < time.Count; i++)
            {
                if (i == time.Count - 1)
                {
                    toNight();
                    gridTime.Add(TimeSpan.Parse(time[i]) + toNight());
                    break;
                }
                gridTime.Add(TimeSpan.Parse(time[i]) + TimeSpan.Parse(dur[i]));
            }
            
            foreach (var item in gridTime)
            {
                toDateTime.Add(new DateTime(item.Ticks));
            }

            doc = toDateTime.Select(x => x.ToString("HH:mm")).ToList();

            File.WriteAllLines($"{path.Replace("Mapas", "Grades").Replace("13-10-2023.txt", "13-10-2022.txt")}", doc);


            TimeSpan toNight()
            {
                TimeSpan lastElement = new TimeSpan();
                lastElement = TimeSpan.Parse(dur.Last());
                var min = lastElement.Minutes;
                var sec = lastElement.Seconds;
                var sub = min - 1;
                var soma = 59;
                var newTime = new TimeSpan(0, sub, soma);
                return newTime;
            }
        }

    }

}
