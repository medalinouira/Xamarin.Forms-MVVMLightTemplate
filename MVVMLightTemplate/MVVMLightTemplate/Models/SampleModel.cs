/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System.Collections.Generic;

namespace MVVMLightTemplate.Models
{
    public class SampleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<string> Items { get; set; }
    }
}
