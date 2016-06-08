
angular.module('app').controller('mvProductCtrl', function ($scope, mvProduct) {



    $scope.product = mvProduct.query(function () {

    });

});