'use strict';
angular.module('agendaApp')


    .controller('pessoaCtrl', function ($scope, $location, genericApiService, pessoa, tipos, mensagemServicoJs) {
      

        $scope.settipoPessoa = function () {
            $scope.pessoa.tipoPessoa_Id = $scope.tipoPessoa.id;
            
        }

        $scope.del = function (item, lista) {
            if (item.id)
                item.visivel = false;
            else {
                lista.splice(lista.indexOf(item),1);
            }
        }

        $scope.add = function (lista) {
            lista.push({ visivel: true });
        }
        
        $scope.Load = function () {
            $scope.pessoa = pessoa;
            $scope.entidade = 'pessoa';
            $scope.tipos = tipos;
             
            
            if ($scope.pessoa)
                $scope.tipoPessoa = { id: $scope.pessoa.tipoPessoa_Id };


            if ($scope.pessoa.contatos === undefined)
                $scope.pessoa.contatos = [];
        }

        $scope.salvar = function () {
            $scope.pessoa.visivel = true;
            genericApiService.Insert('pessoa', $scope.pessoa).then(function (response) {
                mensagemServicoJs.abrir('Cadastro realizado!', 'Clique Ok para continuar', 'pessoas/' + $scope.tipoPessoa);
            });
        }

        $scope.Load();

    })
 


    .controller('pessoasCtrl', function ($scope, $location, $route, genericApiService, pessoas) {
        $scope.pessoas = pessoas;
        $scope.entidade = 'pessoas';

        $scope.del = function (item) {
            
                item.visivel = false;
                genericApiService.Insert('pessoa', item).then(function (response) {
                    
                    genericApiService.GetList('pessoa', { TipoPessoa_Id:  $route.current.params.tipo  }).then(function (response) {
                        $scope.pessoas = response;
                    });
                });
        }

    })

    .controller('tiposPessoaCtrl', function ($scope, $location, $route, genericApiService, tiposPessoa) {
     $scope.tiposPessoa = tiposPessoa;
     $scope.entidade = 'tiposPessoa';

     $scope.del = function (item) {

         item.visivel = false;
         genericApiService.Insert('tipoPessoa', item).then(function (response) {

             genericApiService.GetList('tipoPessoa', {}).then(function (response) {
                 $scope.tiposPessoa = response;
             });
         });
     }

    })

    .controller('tipoPessoaCtrl', function ($scope, $location, $route, genericApiService, tipoPessoa, mensagemServicoJs) {
      

        $scope.salvar = function () {
            $scope.tipoPessoa.visivel = true;
            genericApiService.Insert('tipoPessoa', $scope.tipoPessoa).then(function (response) {
                mensagemServicoJs.abrir('Cadastro realizado!', 'Clique Ok para continuar', 'tiposPessoa');
            });
        }

        $scope.Load = function () {
            $scope.tipoPessoa = tipoPessoa;
            $scope.entidade = 'tipoPessoa';
        }

        $scope.Load();
    })



    .controller('reservasCtrl', function ($scope, $location, $route, genericApiService, reservas) {
        $scope.reservas = reservas;
        $scope.entidade = 'reservas';

        $scope.del = function (item) {

            item.visivel = false;
            genericApiService.Insert('reserva', item).then(function (response) {

                genericApiService.GetList('reserva', {}).then(function (response) {
                    $scope.reservas = response;
                });
            });
        }

        $scope.selectUsu = function (usu) {
            $scope.solicitacaoVerba.usuarioAporvador = usu;
            $scope.usuarios = [];
        }


    })

    .controller('reservaCtrl', function ($scope, $location, $route, genericApiService, reserva, mensagemServicoJs) {
       
        $scope.selectUsucliente = function (usu) {
            $scope.reserva.cliente = usu;
            $scope.reserva.cliente_Id = usu.id;
          
            $scope.clientes = [];
        }

        $scope.selectUsugencia = function (usu) {
            $scope.reserva.agencia = usu;
            $scope.reserva.agencia_Id = usu.id;

            $scope.agencias = [];
        }

        $scope.selectUsufornecedor = function (usu) {
            $scope.reserva.fornecedor = usu;
            $scope.reserva.fornecedor_Id = usu.id;

            $scope.fornecedors = [];
        }

        $scope.selectorigen = function (origen) {
            $scope.reserva.origem = origen;
            $scope.reserva.origem_Id = origen.id;

            $scope.origens = [];
        }

        $scope.selectdestino = function (destino) {
            $scope.reserva.destino = destino;
            $scope.reserva.destino_Id = destino.id;

            $scope.destinos = [];
        }

        $scope.del = function (item, lista) {
            if (item.id)
                item.visivel = false;
            else {
                lista.splice(lista.indexOf(item), 1);
            }
        }

        $scope.add = function (lista) {
            lista.push({ visivel: true });
        }

        $scope.Load = function () {
            $scope.reserva = reserva != null ? reserva : {};
            $scope.entidade = 'reserva';
            $scope.reserva.cliente_Id = 0;
        }

        $scope.buscaclientes = function (obj) {

            if (obj.nome.length > 4)
                genericApiService.GetList('pessoa', obj).then(function (response) { $scope.clientes = response.data; });

        }

        $scope.buscaagencias = function (obj) {

            if (obj.nome.length > 4)
                genericApiService.GetList('pessoa', obj).then(function (response) { $scope.agencias = response.data; });

        }

        $scope.buscaafornecedors = function (obj) {

            if (obj.nome.length > 4)
                genericApiService.GetList('pessoa', obj).then(function (response) { $scope.fornecedors = response.data; });

        }


        $scope.buscaorigem = function (obj) {

            if (obj.nome.length > 4)
                genericApiService.GetList('itinerario', obj).then(function (response) { $scope.origens = response.data; });

        }

        $scope.buscadestino = function (obj) {

            if (obj.nome.length > 4)
                genericApiService.GetList('itinerario', obj).then(function (response) { $scope.destinos = response.data; });

        }
        
        $scope.salvar = function () {
            $scope.reserva.visivel = true;
            genericApiService.Insert('reserva', $scope.reserva).then(function (response) {
                mensagemServicoJs.abrir('Cadastro realizado!', 'Clique Ok para continuar', 'reservas');
            });
        }

        $scope.Load();
       
        })

    .controller('cadastroCtrl', function ($scope, $location, $sessionStorage, descontos, inscricaoApiService, inscricao) {

    $scope.descontos = descontos;
    $scope.inscricao = inscricao;
    
    $scope.salvar = function () {
        inscricaoApiService.Insert($scope.inscricao).then(function (response) {
            alert('Cadastrado!');
            window.location.href = '#/home';
            },
                function (resposta) {
                    if (resposta.data.message === undefined) { alert('Erro: ' + resposta.data) } else alert('Erro: ' + resposta.data.message);

                });

        };
  
    })


    .controller('itinerarioCtrl', function ($scope, $location, genericApiService, itinerario, mensagemServicoJs) {


    $scope.del = function (item, lista) {
        if (item.id)
            item.visivel = false;
        else {
            lista.splice(lista.indexOf(item), 1);
        }
    }

    $scope.add = function (lista) {
        lista.push({ visivel: true });
    }

    $scope.Load = function () {
        $scope.itinerario = itinerario;
        $scope.entidade = 'itinerario';
       
        
    }

    $scope.salvar = function () {
        $scope.itinerario.visivel = true;
        genericApiService.Insert('itinerario', $scope.itinerario).then(function (response) {
            mensagemServicoJs.abrir('Cadastro realizado!', 'Clique Ok para continuar', 'itinerarios');
        });
    }

    $scope.Load();

    })

    .controller('itinerariosCtrl', function ($scope, $location, genericApiService, itinerarios, mensagemServicoJs) {

        $scope.Load = function () {
            $scope.itinerarios = itinerarios;
            $scope.entidade = 'itinerario';
           

        }

        $scope.Load();

    })

;