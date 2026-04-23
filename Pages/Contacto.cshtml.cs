using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace waPWS2026Core.Pages
{
    public class ContactoModel : PageModel
    {
        [BindProperty]
        public FormContacto Contacto { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            //Validación del lado del servidor 
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                TempData["Mensaje"] = "¡Formulario enviado con éxito!";
                return RedirectToPage();
            }
        }
    }

    public class FormContacto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string tbNombre { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido")]
        public string tbEmail { get; set; }

        [Required(ErrorMessage = "Seleccione un tipo")]
        public string TipoComentario { get; set; }

        [Required(ErrorMessage = "Escriba su comentario")]
        [StringLength(5, ErrorMessage = "Máximo 5 caractereres.")]
        public string tbComentarios { get; set; }
    }
}

