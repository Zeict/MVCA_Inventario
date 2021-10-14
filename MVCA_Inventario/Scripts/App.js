var app = angular.module('HomeApp', []);
app.controller('HomeController', function ($scope, $http)
{

 

    $http({
        method: 'GET',
        url: '@Url.Action("getProduct", "Home")',
        headers: {
            'Content-type': 'application/json'
        }
    }).then(function (response) {
        debugger;
        $scope.employee = JSON.parse(response.data);
    }, function (error) {
        console.log(error);
    });

    $scope.AddEmployee = function () {
        debugger;
        var eee = $scope.model;
        $http({
            method: 'POST',
            url: '@Url.Action("addProduct", "Home")',
            data: $scope.model,
            headers: {
                'Content-type': 'application/json'
            }
        }).then(function (response) {
            $scope.employee = JSON.parse(response.data);
            $scope.message = "Producto Agregado Correctamente";

            $("#AddModal").modal("hide");
        }, function (error) {
            console.log(error);
        });
    }

    $scope.selectUser = function (names) {
        $scope.selectedUser = names;
    }

    $scope.UpdateEmployee = function () {
        var eee = $scope.selectedUser;
        $http({
            method: 'POST',
            url: '@Url.Action("updateProduct", "Home")',
            data: $scope.selectedUser,
            headers: {
                'Content-type': 'application/json'
            }
        }).then(function (response) {
            $scope.employee = JSON.parse(response.data);
            $scope.message = "Producto Actualizado Correctamente";
            $("#EditModal").modal("hide");
        }, function (error) {
            console.log(error);
        });
    }

    $scope.DeleteEmployee = function (names) {

        $http({
            method: 'POST',
            url: '@Url.Action("deleteProduct", "Home")',
            data: names,
            headers: {
                'Content-type': 'application/json'
            }
        }).then(function (response) {
            $scope.employee = JSON.parse(response.data);
            $scope.message = "Producto Eliminado Correctamente";
            $("#EditModal").modal("hide");
        }, function (error) {
            console.log(error);
        });
    }
    $scope.clearModel = function () {
        $scope.model = null;

    }

});