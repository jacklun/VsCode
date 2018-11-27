    /**
     *  Jquery.Iboot.js V1.0.0
     *  Create on 2018?10?12?15:33:08
     *  Author: jon-millent
     *  Github: https://github.com/Jon-Millent/iboot
     *  Protocol: MIT
     */

; (function ($, root)
{
    function Iboot(ele, config)
    {
        this.ele = $(ele)
        this.eleWidth = this.ele.width()

        this.config = $.extend({
        baseHeight: 300, // ????
        mediaBaseHeight: [ //???????

        ],
        list: [
            {
                src: '',
                alt: 'xxx'
            }
        ],
        template: function (dom)
        {
            return dom
        },
        scrollBox: $(document.body),

        afterLoad: function ()
        {

        },

        beforeLoad: function ()
        {

        }
        }, config)

        this.innerData = {
            nowItemWidth: 0, //???????
            appendDoms: [],
            scrollBoxData: {

            },
            saveDom: [],
            groupid: 0
        }
    }

    Iboot.prototype.init = function ()
    {
        var _this = this

        this.beforeLoad()
        this.loader(this.config.list, function (cp, img)
        {
        _this.render(cp, img)
        }, function (cp, img, error)
        {

        }, function ()
        {
        _this.afterLoad()
        })

        return this
    }

    Iboot.prototype.beforeLoad = function ()
    {
        this.innerData.scrollBoxData.overflowY = this.config.scrollBox.css('overflow-y')
        this.config.scrollBox.css('overflow-y', 'scroll')
        this.config.beforeLoad()
    }

    Iboot.prototype.afterLoad = function ()
    {
        this.config.scrollBox.css('overflow-y', this.innerData.scrollBoxData.overflowY)
        this.innerData.nowItemWidth = 0
        this.innerData.appendDoms = []
        this.innerData.groupid = 0

        // ????group id ?
        $.each(this.innerData.saveDom, function (k, v)
        {
        var data = $(v).attr('group')
        if (!data)
        {
            $(v).hide()
        }
        })

        this.config.afterLoad()
    }

    Iboot.prototype.template = function (src, alt)
    {
        var item = $('<div class="iboot-item" style="float: left;"></div>');
        item.append(
        $('<img src="' + src + '" alt="' + alt + '" style="width: 100%; height: auto; padding:4px; border:0px solid red;">')
        );
        return this.config.template(
        item
        )
    }

    Iboot.prototype.render = function (cp, img)
    {

        var _this = this
        var dom = this.template(cp.src, cp.alt)
        //img.width = Srr(200, 500)
        //img.height = Srr(200, 500)
        var scale = img.width / img.height
        alert(img.width);
        dom.attr({
            'data-rew': img.width,
            'data-reh': img.height,
            'data-scale': scale
        })

        var comp = {
            width: scale * this.config.baseHeight,
            height: this.config.baseHeight,
        }

        this.innerData.nowItemWidth += comp.width
        this.innerData.appendDoms.push(dom)
        this.innerData.saveDom.push(dom)

        dom.css({
            height: comp.height,
            width: comp.width
        })

        this.ele.append(dom)

        var compW = this.innerData.nowItemWidth - this.ele.width()

        if (compW > 0)
        {

        // ????????
        var nowScale = this.innerData.nowItemWidth / this.getMediaHeight()

        var scaleHeight = this.ele.width() / nowScale

        // ????
        $.each(this.innerData.appendDoms, function (i, v)
        {

            var data = $(v).data()

            $(v).css({
            height: scaleHeight,
            width: data.scale * scaleHeight
            })

            $(v).attr('group', _this.innerData.groupid)

        })

        this.innerData.nowItemWidth = 0
        this.innerData.appendDoms = []
        this.innerData.groupid++
        }

    }

    Iboot.prototype.loader = function (list, success, error, done)
    {
        var now = 0;
        $.each(list, function (i, v)
        {
            (function (i, v)
            {
                var img = new Image()
                img.onload = function ()
                {
                    success(v, img)
                    now++
                    if (now === list.length)
                    {
                        done()
                    }
                }
                img.onerror = function (err)
                {
                    error(v, img, err)
                    now++
                    if (now === list.length)
                    {
                        done()
                    }
                }
                img.src = v.src
                img.alt = v.alt
            })(i, v);
        })
    }

    Iboot.prototype.getMediaHeight = function ()
    {
        return this.config.baseHeight
    }

    Iboot.prototype.resize = function ()
    {

        var baseHeight = this.getMediaHeight()
        var _this = this
        $.each(this.innerData.saveDom, function (i, v)
        {

        // ???????group id
        $.each(_this.innerData.appendDoms, function (i, v)
        {
            $(v).removeAttr('groupid')
            $(v).show()
        })

        var data = $(v).data()

        var cof = {
            height: baseHeight,
            width: baseHeight * data.scale
        }
        _this.innerData.appendDoms.push(v)
        _this.innerData.nowItemWidth += cof.width

        var compW = _this.innerData.nowItemWidth - _this.ele.width()

        if (compW > 0)
        {

            // ????????
            var nowScale = _this.innerData.nowItemWidth / _this.getMediaHeight()

            var scaleHeight = _this.ele.width() / nowScale

            $.each(_this.innerData.appendDoms, function (i, v)
            {
            var data = $(v).data()

            $(v).css({
                height: scaleHeight,
                width: data.scale * scaleHeight
            })

            $(v).attr('group', _this.innerData.groupid)

            })

            _this.innerData.nowItemWidth = 0
            _this.innerData.appendDoms = []
            _this.innerData.groupid++
        }

        })

        _this.innerData.nowItemWidth = 0
        _this.innerData.appendDoms = []
        _this.innerData.groupid = 0

        // ????group id ?
        $.each(this.innerData.saveDom, function (k, v)
        {
        var data = $(v).attr('group')
        if (!data)
        {
            $(v).hide()
        }
        })
    }

    Iboot.prototype.loadMore = function (list)
    {
        var _this = this
        // ?????????
        var coc = []
        $.each(this.innerData.saveDom, function (i, v)
        {
        var data = $(v).attr('group')
        if (!data)
        {
            if (!v)
            {
            return
            }
            var img = $(v).find('img')
            coc.push({
            src: img.attr('src'),
            alt: img.attr('alt'),
            })
            _this.innerData.saveDom.splice(i, 1)
        }
        })

        list = coc.concat(list)

        this.beforeLoad()
        this.loader(list, function (cp, img)
        {
            _this.render(cp, img)
        },
        function (cp, img, error)
        {

        },
        function ()
        {
            _this.afterLoad()
        })
    }

    root.Iboot = function (ele, config)
    {
        return new Iboot(ele, config).init();
    }

})(jQuery, window);

function Srr(lowValue, highValue)
{
    var choice = highValue - lowValue + 1;
    var x = Math.floor(Math.random() * choice + lowValue);
    return x;
}
function shuffle(a)
{
    var j, x, i;
    for (i = a.length; i; i--)
    {
        j = Math.floor(Math.random() * i);
        x = a[i - 1];
        a[i - 1] = a[j];
        a[j] = x;
    }
}