using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.API.ViewModels
{
    public class EnderecoViewModel
    {
            [Key]
            public Guid Id { get; set; }

            [Required(ErrorMessage = "O campo {0} é obrigatório")]
            [StringLength(200, /*ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",*/ MinimumLength = 2)]
            public string Logradouro { get; set; }

            [Required(ErrorMessage = "O campo {0} é obrigatório")]
            [StringLength(50, /*ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",*/ MinimumLength = 1)]
            public string Numero { get; set; }

            public string Complemento { get; set; }

            [Required(ErrorMessage = "O campo {0} é obrigatório")]
            [StringLength(100, /*ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",*/ MinimumLength = 2)]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "O campo {0} é obrigatório")]
            [StringLength(8, /*ErrorMessage = "O campo {0} precisa ter {1} caracteres",*/ MinimumLength = 8)]
            public string Cep { get; set; }

            [Required(ErrorMessage = "O campo {0} é obrigatório")]
            [StringLength(100, /*ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",*/ MinimumLength = 2)]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "O campo {0} é obrigatório")]
            [StringLength(50, /*ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres",*/ MinimumLength = 2)]
            public string Estado { get; set; }

            public Guid FornecedorId { get; set; }
        }
    }

//https://csharp2json.io/ gerador de json
//
//public class FornecedorViewModel
//{

//    public Guid Id { get; set; }

//    public string Nome { get; set; }

//    public int TipoFornecedor { get; set; }

//    public EnderecoViewModel Endereco { get; set; }

//    public bool Ativo { get; set; }

//}


//public class EnderecoViewModel
//{
//    public Guid Id { get; set; }

//    public string Logradouro { get; set; }

//    public string Numero { get; set; }

//    public string Complemento { get; set; }

//    public string Bairro { get; set; }

//    public string Cep { get; set; }

//    public string Cidade { get; set; }

//    public string Estado { get; set; }

//    public Guid FornecedorId { get; set; }
//}


////https://www.guidgenerator.com/
//https://www.geradordecpf.org/

//{
//    "id": "cc8e83dd-f9b2-44a7-b994-59a0280c43fe",
//  "nome": "Casa Nerd",
//  "documento": "60886710766",
//  "tipoFornecedor": 1,
//  "endereco": {
//        "id": "2a7517f8-f70e-4e0d-af8d-a2363be76bcb",
//    "logradouro": "rua Teste",
//    "numero": 123,
//    "complemento": "",
//    "bairro": "teste",
//    "cep": "38408500",
//    "cidade": "Uberlandia",
//    "estado": "MG",
//    "fornecedorId": "00000000-0000-0000-0000-000000000000"
//    },
//  "ativo": true
//}



