
angular.module('app').controller('mvProductDetailCtrl', function ($scope, mvProduct, mvProductCUD, $routeParams, $location) {

    


    mvProduct.get({ id: $routeParams.id }, function (product) {
        $scope.name = product[0].Name;

    });

     $scope.update = function() {
         var newProductData = {
             productId:$routeParams.id ,
            name: $scope.name,
            created: new Date()
        };

         mvProductCUD.addOrUpdateProduct(newProductData).then(function (response) {
            $location.path('/');
           
        }, function (reason) {
           
        });
    };

   
});
