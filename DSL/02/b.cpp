#include <bits/stdc++.h>
#define REP(i, n) for(int i = 0; i < n; ++i)
#define REPP(i, n) for(int i = 1; i <= n; ++i)
#define REPR(i, n) for(int i = n-1; i >= 0; --i)
#define FOR(i, m, n) for(int i = m; i < n; ++i)
#define ALL(v) v.begin(), v.end()
using namespace std;
typedef long long ll;
const ll MOD = 1000000007;

template<typename T1,typename T2> inline void chmin(T1 &a,T2 b) {if(a>b) a=b;}
template<typename T1,typename T2> inline void chmax(T1 &a,T2 b) {if(a<b) a=b;}

template<typename T>
struct BinaryIndexedTree {
    vector<T> data;
    int n;
    BinaryIndexedTree(int n) : n(n), data(++n,0) {}
    T sum(int i) {
        T res = 0;
        for(++i; i>0; i -= (i&-i)) res += data[i];
        return res;
    }
    void add(int i, T x) {
        for(++ i; i < n; i += i&-i) data[i] += x;
    }
};

int main() {
    cin.tie(0);
    ios::sync_with_stdio(false);
    int n,q; cin >> n >> q;
    BinaryIndexedTree<int> bit(n);
    REP(i,q) {
        int c,x,y; cin >> c >> x >> y; --x,--y;
        if(!c) bit.add(x,++y);
        else {
            int s = bit.sum(y) - bit.sum(x-1);
            cout << s << '\n';
        }
    }
    return 0;
}