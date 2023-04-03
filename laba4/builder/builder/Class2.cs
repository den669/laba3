using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
        public abstract class Pizza
        {
            public abstract Pizza Copy();
        }

        public class Pizzza : Pizza
        {
            public string crust, sauce, toppings;
            public string Data() => crust + "\n" + sauce + "\n" + toppings + "\n";
            public void GetCrust(string dat) => crust = dat;
            public void GetSauce(string dat) => sauce = dat;
            public void GetToppings(string dat) => toppings = dat;

            public override Pizza Copy()
            {

                Pizzza clone = (Pizzza)this.MemberwiseClone();
                clone.crust = String.Copy(crust);
                clone.sauce = String.Copy(sauce);
                clone.toppings = String.Copy(toppings);
                return clone;
            }

        }

        public interface Builder
        {
            void BuildCrust();

            void BuildSauce();

            void BuildToppings();
            Pizzza GetPizza();
        }
        public class NormalPizzzaBuilder : Builder
        {
            private Pizzza plane;

            public NormalPizzzaBuilder()
            {
                plane = new Pizzza();
            }

            public void BuildCrust()
            {
                plane.GetCrust("Add Crust");
            }

            public void BuildSauce()
            {
                plane.GetSauce("Add Sauce");
            }

            public void BuildToppings()
            {
                plane.GetToppings("Add Toppings");
            }

            public Pizzza GetPizza() => plane;
        }
        public class AwesomePizzzaBuilder : Builder
        {
            private Pizzza piz;

            public AwesomePizzzaBuilder()
            {
                piz = new Pizzza();
            }
            public void BuildCrust()
            {
                piz.GetCrust("Add  awesome Crust");
            }
            public void BuildSauce()
            {
                piz.GetSauce("Add awesome Saucet");
            }

            public void BuildToppings()
            {
                piz.GetToppings("Add  awesome Toppings");
            }

            public Pizzza GetPizza() => piz;

        }
        public class Director
        {
            private Builder builder;

            public Director(Builder builder)
            {
                this.builder = builder;

            }
            public void ChosePizzza(Builder builder)
            {
                this.builder = builder;
            }

            public Pizzza Buildpiz()
            {
                builder.BuildCrust();
                builder.BuildSauce();
                builder.BuildToppings();
                return builder.GetPizza();
            }

        }


    }

