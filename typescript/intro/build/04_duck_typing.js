"use strict";
console.log('Hello');
const login = (user) => {
    // user.moreStuff // not accessible because the IUser doesn't have a key called moreStuff
    return true;
};
const user = {
    username: 'smjeffery',
    password: '1234',
    moreStuff: true,
};
// below works because user variable has the same structure as IUser
login(user);
