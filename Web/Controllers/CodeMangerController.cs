using core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CodeMangerController : ControllerBase
    {
        private readonly CodeContext codeContext;

        public CodeMangerController(CodeContext codeContext)
        {
            this.codeContext = codeContext;
        }
        [HttpGet("List")]
        public ActionResult List()
        {
            return Ok( codeContext.CodeDescriptions.ToList().Select(c=> new CodeItemDTO(c.Code, c.Type.Name, c.Module.Name, c.Message, c.Description, c.Type.Color)));
        }

        #region CodeType Actions
        [HttpGet("CodeTypeList")]
        public ActionResult CodeTypeList()
        {
            return Ok(codeContext.CodeTypes.ToList().Select(c => new { id = c.Id, name = c.Name, desc = c.Description, color = c.Color }));
        }
        [HttpGet("CodeTypeItem")]
        public ActionResult CodeTypeItem(int id)
        {
            return Ok(codeContext.CodeTypes
                .Where(c => c.Id == id)
                .ToList()
                .Select(c => new { id = c.Id, name = c.Name, desc = c.Description, color = c.Color }
                ));
        }
        [HttpGet("CodeTypeItemDelete")]
        public ActionResult CodeTypeItemDelete(int id)
        {
            var item = codeContext.CodeTypes
                .First(c => c.Id == id);
            this.codeContext.CodeTypes.Remove(item);
            return Ok();

        }
        [HttpPost("CodeTypeEdit")]
        public ActionResult CodeTypeList(CodeTypeDTO codeTypeDTO)
        {

            CodeType editObj = null;
            if (codeTypeDTO.ID > 0)
            {
                editObj = this.codeContext.CodeTypes.First(c => c.Id == codeTypeDTO.ID);
                editObj.Name = codeTypeDTO.Name;
                editObj.Description = codeTypeDTO.Desc;
                editObj.Color = codeTypeDTO.Color;


            }
            else
            {
                editObj = new CodeType();
                editObj.Name = codeTypeDTO.Name;
                editObj.Description = codeTypeDTO.Desc;
                editObj.Color = codeTypeDTO.Color;
                this.codeContext.CodeTypes.Add(editObj);


            }
            this.codeContext.SaveChanges();
            return Ok(editObj?.Id ?? -1);
        } 
        #endregion

    }
    public class CodeTypeDTO
    {

        //id = c.Id, name = c.Name, desc = c.Description, color = c.Color
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Color { get; set; }

    }

    public class CodeItemDTO
    {
        public string Code { get; }
        public string Type { get; }
        public string Moudel { get; }
        public string Message { get; }
        public string Desc { get; }
        public string Color { get; }

        public CodeItemDTO(string code, string type, string moudel, string message, string desc, string color)
        {
            Code = code;
            Type = type;
            Moudel = moudel;
            Message = message;
            Desc = desc;
            Color = color;
        }

        public override bool Equals(object obj)
        {
            return obj is CodeItemDTO other &&
                   Code == other.Code &&
                   Type == other.Type &&
                   Moudel == other.Moudel &&
                   Message == other.Message &&
                   Desc == other.Desc &&
                   Color == other.Color;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Code, Type, Moudel, Message, Desc, Color);
        }
    }
}
