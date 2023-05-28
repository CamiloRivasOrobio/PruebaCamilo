using sistema.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Win32;

namespace sistema.Controllers
{
    public class FilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> UploadFiles(FilesUploadViewModel model)
        {
            try
            {
                var listaUrlArchivos = new List<object>();
                if (model.Archivos != null && model.Archivos.Count > 0)
                {
                    foreach (var file in model.Archivos)
                    {
                        if (file.Length > 0)
                        {

                            var ticks = DateTime.Now.Ticks;
                            var fecha = DateTime.Now.ToString("yyyyMMdd");
                            var nombreArchivo = fecha + ticks;

                            RegistryKey key;
                            object value;
                            key = Registry.ClassesRoot.OpenSubKey(@"MIME\Database\Content Type\" + file.ContentType, false);
                            value = key != null ? key.GetValue("Extension", null) : null;
                            var extension = value != null ? value.ToString() : string.Empty;

                            //var extension = "." + file.ContentType.Split("/")[1];
                            var directorioBase = "wwwroot";
                            var filePath = directorioBase + model.Directorio + nombreArchivo + extension;
                            var urlFinalRegistroBd = model.Directorio + nombreArchivo + extension;

                            if (!Directory.Exists(directorioBase + model.Directorio))
                            {
                                Directory.CreateDirectory(directorioBase + model.Directorio);
                            }
                            using (var stream = System.IO.File.Create(filePath))
                            {
                                await file.CopyToAsync(stream);
                            }

                            listaUrlArchivos.Add(new
                            {
                                nombreArchivo = file.FileName,
                                urlArchivo = urlFinalRegistroBd
                            });
                        }
                    }
                }
                return Json(new
                {
                    exitoso = true,
                    archivos = listaUrlArchivos
                });
            }
            catch (Exception ex)
            {
                return Json(new { exitoso = false, mensaje = "Error al subir archivos. " + ex.Message });
            }
        }
    }
}
