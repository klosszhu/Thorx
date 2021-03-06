﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thorx.MongoToolkit;

namespace MongoTest.model
{
    public class BaseModel : IEntity<Guid?>
    {
        public Guid? Id { get; set; }

        public void Create()
        {
            this.Id = Guid.NewGuid();
        }

        public void Update(Guid? UpdateId)
        {
            this.Id = UpdateId;
        }
    }
}
