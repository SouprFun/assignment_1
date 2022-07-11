function findSum(n) {
    let number
    for (let i = 0; i <= n; i++) {
        if (i % 3 === 0 || i % 5 === 0) {
            number += i;
        }
    }
    return number;
}
