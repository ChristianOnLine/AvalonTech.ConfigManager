using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalonTech.ConfigManager.Model
{
    public interface ITrackChanges
    {
        public string UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserModified { get; set; }
        public DateTime DateModified { get; set; }

    }
}
