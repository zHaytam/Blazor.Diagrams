window.setup = function () {
    Prism.highlightAll();

    var elements = $('.sticky');
    Stickyfill.add(elements);

    $('body').scrollspy({ target: '#doc-menu', offset: 100 });

    $(document).delegate('*[data-toggle="lightbox"]', 'click', function (e) {
        e.preventDefault();
        $(this).ekkoLightbox();
    });

    $('a.scrollto').on('click', function (e) {
        e.preventDefault();
        e.stopPropagation();

        var target = this.hash;
        $('body').scrollTo(target, 800, { offset: 0, 'axis': 'y' });

    });
}