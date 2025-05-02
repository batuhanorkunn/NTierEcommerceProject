﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Configurations
{
	public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IEntity
	{
		public virtual void Configure(EntityTypeBuilder<T> builder)
		{
			
		}
	}
}
