
angular.module('app').controller('mvProductCtrl', function ($scope, mvProduct,mvProductCUD) {



    $scope.product = mvProduct.query(function () {

    });

    $scope.add = function() {
        var newProductData = {
            name: $scope.name,
            created: new Date()
        };

        mvProductCUD.addOrUpdateProduct(newProductData).then(function (response) {
            
            $scope.product.push(response);
            $scope.name = "";
        }, function (reason) {
           
        });
    };

    $scope.delete = function (p) {
        mvProductCUD.deleteProduct(p).then(function () {

            $scope.product.splice($scope.product.indexOf(p), 1);
        }, function (reason) {

        });
        
        };

});