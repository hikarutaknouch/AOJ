#include <bits/stdc++.h>
#define REP(i, n) for(int i = 0; i < n; ++i)
#define REPP(i, n) for(int i = 1; i <= n; i++)
#define REPR(i, n) for(int i = n; i >= 0; i--)
#define FOR(i, m, n) for(int i = m; i < n; i++)
#define ALL(v) v.begin(), v.end()
#define UNIQUE(v) v.erase(unique(v.begin(), v.end()), v.end());
using namespace std;
typedef long long ll;
typedef pair<ll, ll> p;
const ll MOD = 1000000007;

int main() {
    int n; cin >> n;
    list<int> l;
    string s;
    REP(i,n) {
        while (cin>> s) {
            if(s=="deleteFirst") l.pop_front();
            else if(s=="deleteLast") l.pop_back();
            else {
                int x; cin >> x;
                if(s=="insert") {
                    l.push_front(x);
                }
                else {
                    for(auto itr = l.begin(); itr != l.end(); ++itr) {
                        if(*itr == x) {
                            l.erase(itr);
                            break;
                        }
                    }
                }
            }
        }
    }
    for(auto itr = l.begin(); itr != l.end(); ++itr) {
        if(itr==l.begin()) cout << *itr;
        else cout << ' ' << *itr;
    }
    cout << endl;
    return 0;
}