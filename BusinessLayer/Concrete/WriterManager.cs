﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDal writerDal;

		public WriterManager(IWriterDal writerDal)
		{
			this.writerDal = writerDal;
		}

		public void WriterAdd(Writer writer)
		{
			writerDal.Add(writer);	
		}
	}
}
