(function () {
    angular.module('app').controller('app.views.customers.editModal', [
        '$scope', '$uibModalInstance', 'abp.services.app.customer', 'id',
        function ($scope, $uibModalInstance, customerService, id) {
            var vm = this;

            vm.customer = {};

            function init() {
                customerService.get({ id: id })
                    .then(function (result) {
                        vm.customer = result.data;
                    });
            }

            vm.save = function () {
                customerService.update(vm.customer)
                    .then(function () {
                        abp.notify.info(App.localize('SavedSuccessfully'));
                        $uibModalInstance.close();
                    });
            };

            vm.cancel = function () {
                $uibModalInstance.dismiss({});
            };

            init();
        }
    ]);
})();