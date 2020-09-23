using Microsoft.EntityFrameworkCore;
using MYB.Core.Api.DTO;
using MYB.Core.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MYB.Core.Api.Business
{
    public class ContactService : IContactService
    {
        private readonly MYBContext db;

        private Medium medium;
        private ContactEntity entity;
        


        public ContactService(MYBContext mybContext)
        {
            db = mybContext;

        }

        public async Task<ContactDTO> Read(int mediumId, int entityTypeId, int entityid)
        {
            if (db.ContactNumber.Any(x => x.ContactMediumId == mediumId && x.EntityTypeId == entityTypeId && x.EntityId == entityid))
            {
                return await db.ContactNumber.Where(x => x.ContactMediumId == mediumId && x.EntityTypeId == entityTypeId && x.EntityId == entityid).Select(x => new ContactDTO { Id = x.EntityId, Name = x.ContactNumber1 }).FirstOrDefaultAsync();
            }
            else {
                return null;
            }


        }

        //private int contactMediumId
        //{
        //    get
        //    {
        //        int id = 0;
        //        switch (medium.ToString())
        //        {
        //            case "Phone":
        //                id = 1;
        //                break;
        //            case "Fax":
        //                id = 2;
        //                break;
        //            case "Email":
        //                id = 4;
        //                break;
        //            case "Web":
        //                id = 5;
        //                break;

        //        }
        //        return id;

        //    }
        //}

        //private int entityTypeId
        //{
        //    get
        //    {

        //        int id = 0;
        //        switch (entity.ToString())
        //        {
        //            case "Organisation":
        //                id = 1;
        //                break;
        //            case "Person":
        //                id = 3;
        //                break;
        //            case "Address":
        //                id = 2;
        //                break;

        //        }
        //        return id;
        //    }
        //}

    }
}

