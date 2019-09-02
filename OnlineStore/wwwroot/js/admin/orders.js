var app = new Vue({
    el: '#app',
    data: {
        loading: false,
        status: 0,
        orders: [],
        selectedOrder: null
    },

    mounted() {
        this.getOrders();
    },

    watch: {
        status: function () {
            this.getOrders;
        }
    },

    methods: {
        getOrders() {
            this.loading = true;
            axios.get('/orders?status=' + this.status)
                .then(result => {
                    this.orders = result.data;
                    this.loading = false;
                });
        },

        selectOrder(id) {
            this.loading = true;
            axios.get('/orders/' + id)
                .then(result => {
                    this.orders = result.data;
                    this.loading = false;
                });
        },

        updateOrder() {
            this.loading = true;
            axios.put('/orders/', this.selectedOrder.id, null)
                .then(result => {
                    this.loading = false;
                    this.exitOrder();
                    this.getOrders();
                });
        },

        exitOrder() {
            this.selectedOrder = null;
        },     
    },

    computed: {
    }
});