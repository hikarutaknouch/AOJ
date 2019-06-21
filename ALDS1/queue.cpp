#include <bits/stdc++.h>
#define REP(i, n) for(int i = 0; i < n; i++)
#define REPP(i, n) for(int i = 1; i <= n; i++)
#define REPR(i, n) for(int i = n; i >= 0; i--)
#define FOR(i, m, n) for(int i = m; i < n; i++)
#define ALL(v) v.begin(), v.end()
#define UNIQUE(v) v.erase(unique(v.begin(), v.end()), v.end());
using namespace std;
typedef long long ll;
typedef pair<string, ll> p;
const ll MOD = 1000000007;

int main() {
    int n,q; cin >> n >> q;
    queue<p> s;
    REP(i,n) {
        string a; int b; cin >> a >> b;
        s.push(make_pair(a,b));
    }
    int second = 0;
    while(!s.empty()) {
        second += (s.front().second - q >= 0 ? q : s.front().second);
        s.front().second -= q;
        if(s.front().second<=0) {
            cout << s.front().first << " " << second << endl;
            s.pop();
        }
        else {
            s.push(s.front());
            s.pop();
        }
    }
    return 0;
}