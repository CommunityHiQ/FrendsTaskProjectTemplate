using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    public class Class1
    {
        public class Parameters
        {
            /// <summary>
            /// This comment will be displeyd as tool tip at UI.
            /// </summary>
            //[DisplayName("SampleMemberValue")]
            //public <type> MemberName { get; set; }
        }

        /// <summary>
        /// Options for the call
        /// </summary>
        public class Options
        {
            /// <summary>
            /// This comment will be displeyd as tool tip at UI.
            /// </summary>
            //[DefaultValue("\"\"")]
            //public string SampleProperty { get; set; }
        }

        public class Output
        {
            //TODO: Implement output object here.
        }

        public class Input
        {
            //TODO: Implement input fields here.
            //[DefaultValue("\"\"")]
            //public string SampleProperty { get; set; }
        }

        public class Execute
        {
            //Sample task method.
            public Output Task(Input input, Parameters parameters, Options options)
            {
                //TODO: implement task business logic here.
                return new Output();
            }
        }
    }
}
