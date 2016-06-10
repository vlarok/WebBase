angular.module('app', ['ngResource',  'ngRoute', 'ui.bootstrap']);


angular.module('app').config(function ($routeProvider, $locationProvider) {
    

 
   
    $locationProvider.html5Mode(true);
    $routeProvider
        .when('/', {
            templateUrl: '/public/app/product/product.html',
            controller: 'mvProductCtrl'
        })
        .when('/add', {
            templateUrl: '/public/app/product/productAdd.html',
            controller: 'mvProductAddCtrl'
        })
    .when('/view/:id', {
        templateUrl: '/public/app/product/productView.html',
        controller: 'mvProductViewCtrl'
    }).when('/comment/:id', {
        templateUrl: '/public/app/comment/comment.html',
        controller: 'mvCommentCtrl'
    })
        .when('/product/:id', {
            templateUrl: '/public/app/product/productDetail.html',
            controller: 'mvProductDetailCtrl'
        })
        .otherwise({ redirectTo: '/404' });

});
