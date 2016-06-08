angular.module('app', ['ngResource',  'ngRoute', 'ui.bootstrap']);


angular.module('app').config(function ($routeProvider, $locationProvider) {
    

 
   
    $locationProvider.html5Mode(true);
    $routeProvider
        .when('/', {
            templateUrl: '/public/app/product/product.html',
            controller: 'mvProductCtrl'
        })
        .when('/product/:id', {
            templateUrl: '/public/app/product/productDetail.html',
            controller: 'mvProductDetailCtrl'
        })
        .otherwise({ redirectTo: '/404' });

});
