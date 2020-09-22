angular.module("agendaApp", ['ngRoute', 'ngStorage', 'angularUtils.directives.dirPagination', 'naif.base64', 'ui.utils.masks', 'ui.bootstrap'])
.config(['$routeProvider', '$locationProvider',
	function ($routeProvider, $locationProvider) {

	    $routeProvider.when('/pessoa/:id', {
	        templateUrl: 'views/Pessoa.html',
	        controller: 'pessoaCtrl',
	        title: 'Cadastro Pessoa',
	        resolve: {
	            pessoa: function ($q, $routeParams, $route, genericApiService) {
	               
	                var deferred = $q.defer();
	               
	                genericApiService.Get('pessoa', { Id: $route.current.params.id }).then(function (response) { deferred.resolve(response.data); });
	                return deferred.promise;
	            },
	            tipos: function ($q, $routeParams, $route, genericApiService) {

	                var deferred = $q.defer();
	                
	                genericApiService.GetList('tipopessoa', {}).then(function (response) { deferred.resolve(response.data); });


	                return deferred.promise;
	            }
	        }
	       
	    });

	    $routeProvider.when('/pessoas/:tipo', {
	        templateUrl: 'views/Pessoas.html',
	        controller: 'pessoasCtrl',
	        title: 'Pessoas',
	        resolve: {
	            pessoas: function ($q, $routeParams, $route, genericApiService) {
	               
	                var deferred = $q.defer();
	                if ($route.current.params.tipo != 0)
	                    genericApiService.GetList('pessoa', { TipoPessoa_Id:$route.current.params.tipo }).then(function (response) { deferred.resolve(response.data); });

	              
	                return deferred.promise;
	            }
	        }
	    });

	    $routeProvider.when('/tiposPessoa', {
	        templateUrl: 'views/tiposPessoa.html',
	        controller: 'tiposPessoaCtrl',
	        title: 'Tipos de Pessoas',
	        resolve: {
	            tiposPessoa: function ($q, $routeParams, $route, genericApiService) {

	                var deferred = $q.defer();
	               
	                   genericApiService.GetList('tipoPessoa', {  }).then(function (response) { deferred.resolve(response.data); });


	                return deferred.promise;
	            }
	        }
	    });

	    $routeProvider.when('/tipoPessoa/:id', {
	        templateUrl: 'views/tipoPessoa.html',
	        controller: 'tipoPessoaCtrl',
	        title: 'Cadastro Tipo de Pessoa',
	        resolve: {
	            tipoPessoa: function ($q, $routeParams, $route, genericApiService) {

	                var deferred = $q.defer();

	                genericApiService.Get('tipoPessoa', { Id: $route.current.params.id }).then(function (response) { deferred.resolve(response.data); });
	                return deferred.promise;
	            }
	        }

	    });

	    
        $routeProvider.when('/reservas', {
            templateUrl: 'views/Reservas.html',
            controller: 'reservasCtrl',
            title: 'Reservas',
            resolve: {
                reservas: function ($q, $routeParams, $route, genericApiService) {
                
                    var deferred = $q.defer();
                    genericApiService.GetList('reserva', {}).then(function (response) { deferred.resolve(response.data); });


                    return deferred.promise;
                }
            }
        });

        $routeProvider.when('/reserva/:id', {
            templateUrl: 'views/Reserva.html',
            controller: 'reservaCtrl',
            title: 'Reserva',
            resolve: {
                reserva: function ($q, $routeParams, $route, genericApiService) {

                    var deferred = $q.defer();
                    genericApiService.Get('reserva', { Id: $route.current.params.id }).then(function (response) { deferred.resolve(response.data); });
                    return deferred.promise;
                    return {};
                }
            }
        });

        $routeProvider.when('/itinerarios', {
            templateUrl: 'views/Itinerarios.html',
            controller: 'itinerariosCtrl',
            title: 'Itinerarios',
            resolve: {
                itinerarios: function ($q, $routeParams, $route, genericApiService) {

                    var deferred = $q.defer();
                    genericApiService.GetList('itinerario', {}).then(function (response) { deferred.resolve(response.data); });


                    return deferred.promise;
                }
            }
        });

        $routeProvider.when('/itinerario/:id', {
            templateUrl: 'views/Itinerario.html',
            controller: 'itinerarioCtrl',
            title: 'Itinerario',
            resolve: {
                itinerario: function ($q, $routeParams, $route, genericApiService) {

                    var deferred = $q.defer();
                    genericApiService.Get('itinerario', { Id: $route.current.params.id }).then(function (response) { deferred.resolve(response.data); });
                    return deferred.promise;
                    return {};
                }
            }
        });
	    

	    $routeProvider.otherwise({ redirectTo: "/pessoa" });
	}])


.service('objectServicearr', function () {
    var objectList = [];

    var _addobject = function (newObj) {
        objectList.push(newObj);
    };

    var _getobjects = function () {
        var ret = objectList;
        addobject = [];
        return ret;
    };

    return {
        addobject: _addobject,
        getobjects: _getobjects
    };

})
.service('objectService', function () {
        var object = {};

        var _addobject = function (newObj) {
            object = newObj;
        };

        var _getobject = function () {
            var ret = object;
            object = null;
            return ret;
        };

        return {
            addobject: _addobject,
            getobject: _getobject
        };

})
.service('getUser', function (LG_URL, $q, userApiService) {
     
    var _resu = function () {
        var deferred = $q.defer();
        userApiService.GetUser().then(function (response) {
            deferred.resolve(response.data);
        }, function (resposta) {
            if (resposta.data.message === undefined) { alert('Erro: ' + resposta.data) } else alert('Erro: ' + resposta.data.message);
            if (resposta.statusText === 'Unauthorized') { $sessionStorage.$reset(); window.location.href = 'http://si.firjan.org.br/siacesso'; }
        });

        return deferred.promise;
    };

    return { resu: _resu };
})


 .run(function ($rootScope, $location, $route, $timeout, $routeParams, $window) {

     $rootScope.config = {};
     $rootScope.config.app_url = $location.url();
     $rootScope.config.app_path = $location.path();
     $rootScope.layout = {};
     $rootScope.layout.loading = false;
    
     $rootScope.$on('$routeChangeStart', function () {
         console.log('$routeChangeStart');
         //show loading gif
         $timeout(function () {
             $rootScope.layout.loading = true;
         });

       

     });
     $rootScope.$on('$routeChangeSuccess', function () {

         $rootScope.title = $route.current.title;

         console.log('$routeChangeSuccess');
         //hide loading gif
         $timeout(function () {
             $rootScope.layout.loading = false;
         }, 200);

         var output = $location.path() + "?";
         angular.forEach($routeParams, function (value, key) {
             output += key + "=" + value + "&";
         })
         output = output.substr(0, output.length - 1);
         
         //$window.ga('send', 'pageview', $location.path());
         //ga('send', 'pageview', $location.path());
     });
     $rootScope.$on('$routeChangeError', function () {

         //hide loading gif
         alert('wtff');
         $rootScope.layout.loading = false;

     });
 })

.directive("uiCpf", function () {
    return {
        scope: {},
        require: "ngModel",
        restrict: 'A',
        link: function (scope, element, attrs, ctrl) {
            var _formatCPF = function (cpf) {
                cpf = cpf.replace(/[^0-9]+/g, "");
                if (cpf.length > 3) {
                    cpf = cpf.substring(0, 3) + "." + cpf.substring(3);
                }
                if (cpf.length > 7) {
                    cpf = cpf.substring(0, 7) + "." + cpf.substring(7);
                }
                if (cpf.length > 11) {
                    cpf = cpf.substring(0, 11) + "-" + cpf.substring(11, 13);
                }
                return cpf;
            }
            element.bind("keyup", function () {
                ctrl.$setViewValue(_formatCPF(ctrl.$viewValue));
                ctrl.$render();
            })

            ctrl.$parsers.push(function (value) {
                //debugger
                if (value.length === 14) {

                    var _cpf = value.replace(/\D/g, "");
                    if (isValido(_cpf)) {
                        ctrl.$setValidity('cpf_valor', true);
                    } else {
                        ctrl.$setValidity('cpf_valor', false);
                    }

                    return _cpf;
                }
                return "";
            });

            ctrl.$formatters.push(function (value) {
                //debugger
                var valor = value.replace(/\D/g, "");                 //Remove tudo o que não é dígito
                valor = valor.replace(/(\d{3})(\d)/, "$1.$2");    //Coloca ponto entre o terceiro e o quarto dígitos
                valor = valor.replace(/(\d{3})(\d)/, "$1.$2");    //Coloca ponto entre o setimo e o oitava dígitos
                valor = valor.replace(/(\d{3})(\d)/, "$1-$2");   //Coloca traço entre o decimoprimeiro e o decimosegundo dígitos

                return valor;
            });

            isValido = function (cpf) {

                var isok = true;
                var myCPF;

                myCPF = cpf.replace('.', '').replace('.', '').replace('-', '');
                var numeros, digitos, soma, i, resultado, digitos_iguais;
                digitos_iguais = 1;

                if (myCPF.length < 11) {
                    isok = false;
                }
                for (i = 0; i < myCPF.length - 1; i++)
                    if (myCPF.charAt(i) != myCPF.charAt(i + 1)) {
                        digitos_iguais = 0;
                        break;
                    }
                if (!digitos_iguais) {
                    numeros = myCPF.substring(0, 9);
                    digitos = myCPF.substring(9);
                    soma = 0;
                    for (i = 10; i > 1; i--)
                        soma += numeros.charAt(10 - i) * i;
                    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
                    if (resultado != digitos.charAt(0)) {
                        isok = false;
                    }
                    numeros = myCPF.substring(0, 10);
                    soma = 0;
                    for (i = 11; i > 1; i--)
                        soma += numeros.charAt(11 - i) * i;
                    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
                    if (resultado != digitos.charAt(1)) {
                        isok = false;
                    }
                }
                else {
                    isok = false;
                }
                return isok;
            }
        }
    };
})
.directive("uiCnpj", function () {
    return {
        scope: {},
        require: "ngModel",
        restrict: 'A',
        link: function (scope, element, attrs, ctrl) {
            var _formatCNPJ = function (cnpj) {
                cnpj = cnpj.replace(/[^0-9]+/g, "");
                if (cnpj.length > 3) {
                    cnpj = cnpj.substring(0, 2) + "." + cnpj.substring(2);
                }
                if (cnpj.length > 7) {
                    cnpj = cnpj.substring(0, 6) + "." + cnpj.substring(6);
                }
                if (cnpj.length > 11) {
                    cnpj = cnpj.substring(0, 10) + "/" + cnpj.substring(10);
                }
                if (cnpj.length > 16) {
                    cnpj = cnpj.substring(0, 15) + "-" + cnpj.substring(15, 17);
                }
                return cnpj;
            }
            element.bind("keyup", function () {
                ctrl.$setViewValue(_formatCNPJ(ctrl.$viewValue));
                ctrl.$render();
            })

            ctrl.$parsers.push(function (value) {
                //debugger
                if (value.length === 18) {

                    var _cnpj = value.replace(/\D/g, "");
                    if (isValido(_cnpj)) {
                        ctrl.$setValidity('cnpj_valor', true);
                    } else {
                        ctrl.$setValidity('cnpj_valor', false);
                    }

                    return _cnpj;
                }
                return "";
            });

            ctrl.$formatters.push(function (value) {
                //debugger
                if (value == null)
                    return value;
                var valor = value.replace(/\D/g, "");                 //Remove tudo o que não é dígito
                valor = valor.replace(/(\d{3})(\d)/, "$1.$2");    //Coloca ponto entre o terceiro e o quarto dígitos
                valor = valor.replace(/(\d{3})(\d)/, "$1.$2");    //Coloca ponto entre o setimo e o oitava dígitos
                valor = valor.replace(/(\d{3})(\d)/, "$1-$2");   //Coloca traço entre o decimoprimeiro e o decimosegundo dígitos

                return valor;
            });

            isValido = function validarCNPJ(cnpj) {

                cnpj = cnpj.replace(/[^\d]+/g, '');

                if (cnpj == '') return false;

                if (cnpj.length != 14)
                    return false;

                // LINHA 10 - Elimina CNPJs invalidos conhecidos
                if (cnpj == "00000000000000" ||
                    cnpj == "11111111111111" ||
                    cnpj == "22222222222222" ||
                    cnpj == "33333333333333" ||
                    cnpj == "44444444444444" ||
                    cnpj == "55555555555555" ||
                    cnpj == "66666666666666" ||
                    cnpj == "77777777777777" ||
                    cnpj == "88888888888888" ||
                    cnpj == "99999999999999")
                    return false; // LINHA 21

                // Valida DVs LINHA 23 -
                tamanho = cnpj.length - 2
                numeros = cnpj.substring(0, tamanho);
                digitos = cnpj.substring(tamanho);
                soma = 0;
                pos = tamanho - 7;
                for (i = tamanho; i >= 1; i--) {
                    soma += numeros.charAt(tamanho - i) * pos--;
                    if (pos < 2)
                        pos = 9;
                }
                resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
                if (resultado != digitos.charAt(0))
                    return false;

                tamanho = tamanho + 1;
                numeros = cnpj.substring(0, tamanho);
                soma = 0;
                pos = tamanho - 7;
                for (i = tamanho; i >= 1; i--) {
                    soma += numeros.charAt(tamanho - i) * pos--;
                    if (pos < 2)
                        pos = 9;
                }
                resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
                if (resultado != digitos.charAt(1))
                    return false; // LINHA 49

                return true; // LINHA 51

            }
        }
    };
})
.directive("uiCep", function () {
    return {
        require: "ngModel",
        restrict: 'A',
        link: function (scope, element, attrs, ctrl) {
            var _formatCEP = function (cep) {
                cep = cep.replace(/[^0-9]+/g, "");
                if (cep.length > 5) {
                    cep = cep.substring(0, 5) + "-" + cep.substring(5, 8);
                }
                return cep;
            }
            element.bind("keyup", function () {
                ctrl.$setViewValue(_formatCEP(ctrl.$viewValue));
                ctrl.$render();
            })

            ctrl.$parsers.push(function (value) {
                if (value.length === 9) {
                    return value.replace(/\D/g, "");
                }
            });

            ctrl.$formatters.push(function (value) {
                var valor = value.replace(/\D/g, "");                 //Remove tudo o que não é dígito
                valor = valor.replace(/(\d{5})(\d)/, "$1-$2");
                return valor;
            });
        }
    };
})
.directive("uiTelefone", function () {
     return {
         require: "ngModel",
         restrict: 'A',
         link: function (scope, element, attrs, ctrl) {
             var _formatTelefone = function (tel) {
                 //debugger
                 if (tel.length < 14) {
                     tel = tel.replace(/[^0-9]+/g, "");
                     if (tel.length > 1) {
                         tel = "(" + tel;
                     }
                     if (tel.length > 3) {
                         tel = tel.substring(0, 3) + ")" + tel.substring(3);
                     }
                     if (tel.length > 8) {
                         tel = tel.substring(0, 8) + "-" + tel.substring(8);
                     }
                 }
                 return tel;
             }
             element.bind("keyup", function () {
                 ctrl.$setViewValue(_formatTelefone(ctrl.$viewValue));
                 ctrl.$render();
             })
             element.bind("blur", function () {
                 //debugger
                 if (element[0].textLength == 14) {
                     var tel = element[0].value.replace(/-/, '');
                     tel = tel.substring(0, 9) + "-" + tel.substring(9);
                     ctrl.$setViewValue(tel);
                     ctrl.$render();
                 }
             })
             ctrl.$parsers.push(function (value) {

                 if (value) {
                     if (value.length >= 13) {
                         ctrl.$setValidity('telefone_valor', true);
                     } else {
                         ctrl.$setValidity('telefone_valor', false);
                     }
                     return value.replace(/\D/g, "");
                 } else {
                     ctrl.$setValidity('telefone_valor', true);
                 }

             });

             ctrl.$formatters.push(function (value) {
                 var valor = value.replace(/\D/g, "");
                 //debugger
                 if (valor) {
                     valor = '(' + valor;
                     valor = valor.replace(/(\d{2})(\d)/, "$1)$2");
                     if (value.length == 10) {
                         valor = valor.replace(/(\d{4})(\d)/, "$1-$2");
                     } else {
                         valor = valor.replace(/(\d{5})(\d)/, "$1-$2");
                     }
                 }
                 return valor;
             });
         }
     };
 })

;