//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyApp
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TextTemplating;
    using System;


    public partial class TestTemplate : global::Microsoft.VisualStudio.TextTemplating.TextTransformation
    {


#line 7 "/Users/yangjiefeng/GitHub/T4-DirectiveProcessor-Example/Included.tt"

        public static class Hello
        {
            public static string sayHello()
            {
                return "Hello, world!";
            }
        }

#line default
#line hidden


#line 8 "/Users/yangjiefeng/GitHub/T4-DirectiveProcessor-Example/Included2.tt"

        public static class Hello2
        {
            public static string sayHello()
            {
                return "Hello, world!";
            }
        }

#line default
#line hidden


#line 6 "/Users/yangjiefeng/GitHub/T4-DirectiveProcessor-Example/TestTemplateClass.tt"


        public class TestTemplateClass : TextTransformation
        {

            public override string TransformText()
            {

#line default
#line hidden


#line 14 "/Users/yangjiefeng/GitHub/T4-DirectiveProcessor-Example/TestTemplateClass.tt"

                this.Write("        ");

#line default
#line hidden


#line 14 "/Users/yangjiefeng/GitHub/T4-DirectiveProcessor-Example/TestTemplateClass.tt"

                this.Write(global::Microsoft.VisualStudio.TextTemplating.ToStringHelper.ToStringWithCulture("Hello, world2."));

#line default
#line hidden


#line 14 "/Users/yangjiefeng/GitHub/T4-DirectiveProcessor-Example/TestTemplateClass.tt"

                this.Write("\n");

#line default
#line hidden


#line 15 "/Users/yangjiefeng/GitHub/T4-DirectiveProcessor-Example/TestTemplateClass.tt"

                return this.GenerationEnvironment.ToString();
            }
        }

#line default
#line hidden


        public override string TransformText()
        {
            this.GenerationEnvironment = null;

#line 7 "/Users/yangjiefeng/GitHub/T4-DirectiveProcessor-Example/Included2.tt"
            this.Write("\n");

#line default
#line hidden

#line 4 "/Users/yangjiefeng/GitHub/T4-DirectiveProcessor-Example/TestTemplate.tt"

            // ...


#line default
#line hidden

#line 7 "/Users/yangjiefeng/GitHub/T4-DirectiveProcessor-Example/TestTemplate.tt"
            this.Write("hello, world.\n");

#line default
#line hidden

#line 8 "/Users/yangjiefeng/GitHub/T4-DirectiveProcessor-Example/TestTemplate.tt"
            this.Write(global::Microsoft.VisualStudio.TextTemplating.ToStringHelper.ToStringWithCulture((new TestTemplateClass()).TransformText()));

#line default
#line hidden

#line 8 "/Users/yangjiefeng/GitHub/T4-DirectiveProcessor-Example/TestTemplate.tt"
            this.Write("\n");

#line default
#line hidden
            return this.GenerationEnvironment.ToString();
        }

        public override void Initialize()
        {
            base.Initialize();
        }
    }
}
