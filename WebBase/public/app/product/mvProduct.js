angular.module('app').factory('mvProduct', function ($resource) {
    var productResource = $resource('/api/product/:ProductId', { _id: "@ProductId" },
        {
            get: { method: 'GET', params: { ProductId: "@ProductId" }, isArray: true },
             delete_product: {
                 method: 'DELETE', params: { ProductId: "@ProductId" }, isArray: false
        }
        }
        );
    return productResource;
});