angular.module('app').factory('mvProduct', function ($resource) {
    var productResource = $resource('/api/product/:id', { _id: "@id" },
    { get: { method: 'GET', params: { id: "@id" }, isArray: true } }
        );
    return productResource;
});