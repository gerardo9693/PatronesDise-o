using PatronesDiseño.FactoryMetod.Interfaces;
using System;

namespace PatronesDiseño.FactoryMetod.Business
{
    public class Windows : IButton
    {
      

        public string OnClick()
        {
            return $"click boton windows";
        }

        //public string render()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
