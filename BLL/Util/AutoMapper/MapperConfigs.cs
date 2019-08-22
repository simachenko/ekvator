using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper.Configuration;
namespace BLL.Util.AutoMapper
{
    class MapperConfigs : MapperConfigurationExpression
    {
        public MapperConfigs()
        {
            AddProfile(new MapperProfile());
        }
    }
}
