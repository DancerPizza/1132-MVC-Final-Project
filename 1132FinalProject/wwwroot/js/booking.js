// booking.js
(function () {
    // 暫存租借紀錄的陣列
    let bookings = [];

    // 取用 DOM
    const locationEl = document.getElementById('Location');
    const timeEl = document.getElementById('Time');
    const sectionEl = document.getElementById('Section');
    const btnSubmit = document.getElementById('btnSubmit');
    const btnView = document.getElementById('btnView');

    // 登記場地事件
    btnSubmit.addEventListener('click', function () {
        const location = locationEl.value.trim();
        const time = timeEl.value.trim();
        const section = sectionEl.value.trim();

        // 檢查有沒有填寫欄位
        if (!location || !time || !section) {
            alert('請填寫所有欄位');
            return;
        }

        // 加到暫存陣列
        bookings.push({ location, time, section });

        // 跳出完成訊息
        alert('登記成功！');

        // 清空表單
        locationEl.value = '';
        timeEl.value = '';
        sectionEl.value = '';
    });

    // 查看已租借場地
    btnView.addEventListener('click', function () {
        if (bookings.length === 0) {
            alert('目前無任何租借紀錄');
            return;
        }

        // 把所有租借項目組成字串, 用字串檢測長度
        let msg = '已租借紀錄：\n\n';
        bookings.forEach(function (b, i) {
            msg += `${i + 1}. 場地：${b.location}\n   時間：${b.time}\n   組別：${b.section}\n\n`;
        });

        alert(msg);
    });
})();
