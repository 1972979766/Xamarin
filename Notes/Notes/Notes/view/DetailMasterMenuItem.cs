using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.view
{

    public class DetailMasterMenuItem
    {
        public DetailMasterMenuItem()
        {
            TargetType = typeof(DetailMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}