var sabio = {
    utilities: {}
    , layout: {}
    , page: {
        handlers: {
        }
        , startUp: null
    }
    , services: {}
    , ui: {}

};


sabio.layout.startUp = function () {

    //console.debug("sabio.layout.startUp");

    //this does a null check on sabio.page.startUp
    if (sabio.page.startUp) {
        //console.debug("sabio.page.startUp");
        sabio.page.startUp();
    }
};



$(document).ready(sabio.layout.startUp);