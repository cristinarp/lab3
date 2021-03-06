﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft.eShopOnContainers.Services.NewTypes.NewTypes.API
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class TypesController : ControllerBase
    {
        private readonly NewTypeContext _newTypeContext;

        public TypesController(NewTypeContext newTypeContext)
        {
            _newTypeContext = newTypeContext;
        }

        [HttpGet]
        public IEnumerable<NewType> Get()
        {
            var totalNewTypes = _newTypeContext.NewTypes;
            return totalNewTypes;
        }
    }
}
