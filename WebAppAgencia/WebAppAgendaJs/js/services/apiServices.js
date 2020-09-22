'use strict';

angular.module('agendaApp')
    .constant('API_URL', 'http://localhost:49476/api/')
   

    .factory('inscricaoApiService', function ($http, API_URL, $sessionStorage,  $window) {

    return {

        GetItem: _GetItem
       , GetList: _GetList
        , Insert: _Insert
        , Remove: _Remove

    };

    function _Remove(id) {

        return $http({
            method: 'DELETE',
            url: API_URL + 'Inscricao/Delete/' + id,
            headers: { 'authorization': 'bearer ' + $sessionStorage.x },
        });


    }

    function _GetItem(id) {

        return $http({
            method: 'GET',
            url: API_URL + 'Inscricao/Get/' + id,
            headers: { 'authorization': 'bearer ' + $sessionStorage.x },
        });


    }

    function _GetList(id) {

        return $http({
            method: 'GET',
            url: API_URL + 'Inscricao/GetList/' + id,
            headers: { 'authorization': 'bearer ' + $sessionStorage.x },
        });


    }

   

    function _Insert(verba) {
        return $http({
            method: 'POST',
            url: API_URL + 'Inscricao/Insert',
            data: verba //,
            , headers: { 'authorization': 'bearer ' + $sessionStorage.x },
        });
    }

   


    })

    .factory('descontosApiService', function ($http, API_URL, $sessionStorage, $window) {

        return {
            GetList: _GetList
        };

       

        function _GetList() {

            return $http({
                method: 'GET',
                url: API_URL + 'Desconto/GetList',
                headers: { 'authorization': 'bearer ' + $sessionStorage.x },
            });


        }




    })

    .factory('genericApiService', function ($http, API_URL, $sessionStorage, $window, mensagemServicoJs) {

      return {
          Get: _Get,
          GetList: _GetList,
          Insert: _Insert,
      };

      function _Get(entidade, obj) {

          return $http({
              method: 'GET',
              url: API_URL + entidade+'/'+obj.Id,
                 
              headers: { 'authorization': 'bearer ' + $sessionStorage.x },
          });

      }

      function _GetList(entidade, obj) {

          return $http({
              method: 'POST',
              url: API_URL + entidade,
              data: obj,
              headers: { 'authorization': 'bearer ' + $sessionStorage.x },
          });

      }

      function _Insert(entidade, obj) {

          var result = $http({
              method: 'PUT',
              url: API_URL + entidade,
              data: obj,
              headers: { 'authorization': 'bearer ' + $sessionStorage.x },
          });
           
          result.error(function (error, status) {
              mensagemServicoJs.abrir(error.message, error.exceptionMessage, '');
             
          });
          return result;
      }
  })

    .factory("mensagemServicoJs", function ($uibModal) {

        var modal = function (titulo, mensagem , url, template) {
             
            var confirmacaoModal = $uibModal.open({
                template: template,
                backdrop: 'static',
                controller: controllerModal,
                windowClass: "modal",
                resolve: {
                    data: function () {
                        return {
                            titulo: titulo,
                            mensagem: mensagem,
                            url: url
                        }
                    }
                }
            });
        }

        var controllerModal = function ($scope, $uibModalInstance, data) {

            $scope.titulo = data.titulo;
            $scope.mensagem = data.mensagem;
            $scope.url = data.url;
            $scope.ok = function () {
                
                $uibModalInstance.close();
                if ($scope.url != '')
                    window.location.href = '#/' + $scope.url;
            };

        };

        return {

            abrir: function (titulo, mensagem, url, rotina) {
                var template = "<div class='modal-header chamada-modal' style='padding: 10px 34px;'>" +
                "<span class='DetalheTituloSpan'>{{titulo}}</span>" +
                "</div>" +
                "<div class='modal-body' style='padding: 16px 0 0 0; font-size: 20px;background-color:#424242;'>" +
                "<p style='padding: 0 36px 0 36px;  color:white;' ng-bind-html='mensagem'>{{mensagem}}</p>" +
                "<button ng-click='ok()' style='width: 100%;margin-top: 20px;' class='botaoModalLista'>" +
                "<div>" +
                "<div style='float:left;width: 100% ;height: 62px;'>" +
                "<div style='margin-top: 20px; margin-left: 5px; text-align:center'>" +
                "<span>Ok</span>" +
                "</div>" +
                "</div>" +
                "</div>" +
                "</button>" +
                "</div>";

                modal(titulo, mensagem, url, template, rotina);
            }
        }
    })

;