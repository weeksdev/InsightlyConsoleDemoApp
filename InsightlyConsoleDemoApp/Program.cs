using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightlyConsoleDemoApp {
    class Program {
        static void Main(string[] args) {
            InsightlySDK.Insightly i = new InsightlySDK.Insightly("e94c2e60-310e-483c-bd20-f32ebdb2732a");
            i.Test();
        }
    }
}
