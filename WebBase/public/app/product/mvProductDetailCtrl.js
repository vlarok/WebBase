
angular.module('app').controller('mvProductDetailCtrl', function ($scope,  mvProduct, $routeParams) {

    


    mvProduct.get({ id: $routeParams.id }, function (product) {
        $scope.name = product[0].Name;

    });

   
});
